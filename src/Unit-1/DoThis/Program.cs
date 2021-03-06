﻿using System;
using Akka.Actor;

namespace WinTail
{
    #region Program
    class Program
    {
        public static ActorSystem MyActorSystem;

        static void Main(string[] args)
        {
            // initialize MyActorSystem
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            Props consoleWriterProps = Props.Create<ConsoleWriterActor>();
            ActorRef consoleWriterActor = MyActorSystem.ActorOf(consoleWriterProps, "consoleWriterActor");

            Props tailCoordinatorProps = Props.Create(() => new TailCoordinatorActor());
            ActorRef tailCoordinatorActor = MyActorSystem.ActorOf(tailCoordinatorProps, "tailCoordinatorActor");

            Props validationActorProps = Props.Create(() => new FileValidatorActor(consoleWriterActor));
            ActorRef validationActor = MyActorSystem.ActorOf(validationActorProps, "validationActor");
            
            Props consoleReaderProps = Props.Create<ConsoleReaderActor>();
            ActorRef consoleReaderActor = MyActorSystem.ActorOf(consoleReaderProps, "consoleReaderActor");

            // tell console reader to begin

            consoleReaderActor.Tell(ConsoleReaderActor.StartCommand);

            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.AwaitTermination();
        }

        private void DoPrintInstructions()
        {
            Console.WriteLine("Please provide the URI of a log file on disk.\n");
        }
    }
    #endregion
}
