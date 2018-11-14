rednet.Open("Right")

if rednet.isOpen("Right") then
  rednet.Host("CNC", "CNC_SVR")
  print("Wireless AP Is Active!")
  goto :NetworkHandler
end

:NetworkHandler
senderID, msg, dist, proto = rednet.receive()
print(msg)
goto :NetworkHandler
