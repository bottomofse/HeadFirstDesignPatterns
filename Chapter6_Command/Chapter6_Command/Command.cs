using System;

namespace Chapter6_Command
{
    internal interface Command
    {
        public void execute();
    }

    internal class Light
    {
        public void on() {
            Console.WriteLine("電気がつきました");
        }

        public void off() {
            Console.WriteLine("電気が消えました");
        }
    }

    internal class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }
    }

    internal  class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl() { }

        public void setCommand(Command command)
        {
            this.slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
