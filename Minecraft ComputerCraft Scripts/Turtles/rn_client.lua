:Entry
local server_id = rednet.Lookup("CNC", "CNC_SVR")


if server_id then
  print("Found Server: " + tostring(server_id))
  print("Awaiting Server Reponse...")
  sendID, msg, proto = rednet.receive()
  print(msg)
  goto :MessageHandling
else
  print("Failed to connect to the remote host.")
  goto :Entry
end



:MessageHandling
local senderid, msg, proto = rednet.receive()

cmd_array = strsplit(":")

if cmd_array[0] == "Mine" then
  print("starting mining module..")
  local mining_script_module = require("Moudles.Mining")
  print("Size: " + cmd_array[1])
   mining_script_module.Miner(tonumber(cmd_array[1]))
else if cmd_array[0] == "Reboot" then
end

goto :MessageHandling

function strsplit(delimiter)
  local result = { }
  local from  = 1
  local delim_from, delim_to = string.find( self, delimiter, from  )
  while delim_from do
    table.insert( result, string.sub( self, from , delim_from-1 ) )
    from  = delim_to + 1
    delim_from, delim_to = string.find( self, delimiter, from  )
  end
  table.insert( result, string.sub( self, from  ) )
  return result
end
