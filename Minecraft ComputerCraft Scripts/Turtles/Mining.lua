function Miner(number SIZE)

turtle.turnRight()
for rightIndex = 0, SIZE do
  state, dat = turtle.inspectRight()
  if CheckMineable(dat.name) then
    turtle.dig()
    turtle.forward()
  else
    turtle.dig()
    turtle.forward()
    DropInvalid()
  end
end

end


function CheckMineable(string blockname)
blockIDs = {"Minecraft:Diamond", "Minecraft:Coal", "Minecraft:Iron", "Minecraft:Gold"}

for x in blockIDs do
  if x == blockname then
    SendMessageToHost("Found Mineable!")
    return true
  end
end

return false
end

function CheckFuel(number size)
  currentFuelLevel = turtle.getFuelLevel()
  JobSize = size * Size
  if currentFuelLevel != JobSize then
    SendMessageToHost("Not Enough Fuel, Trying Refuel..")
  end
end

function DropInvalid()
  for i = 0, 16 do
    turtle.select(i)
    if CheckMineable(turtle.getitemDetail().name) then
      turtle.drop()
    end
  end
end


function SendMessageToHost(string msg)
  rednet.send(0, msg, "CNC")
end
