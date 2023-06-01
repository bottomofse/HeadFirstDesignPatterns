using Chapter6_Command;

SimpleRemoteControl remote = new SimpleRemoteControl();
Light light = new Light();
LightOnCommand lightOn = new LightOnCommand(light);

remote.setCommand(lightOn);
remote.buttonWasPressed();
