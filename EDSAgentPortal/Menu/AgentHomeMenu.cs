using EDSAgentPortal.Services;
using ElectricityDigitalSystem.Data;
using ElectricityDigitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDSAgentPortal.Menu
{
    public class AgentHomeMenu
    {
        public static int CurrentStage { get; set; } = 1;

        public static void HomeMenuDisplay(AgentModel agent)
        {
            bool appIsRunning = true;
            while (appIsRunning)
            {

                while (CurrentStage == 1)
                {

                    Console.Clear();
                    Console.WriteLine($"\t\t\t\t\t\tWelcome {agent.FirstName} {agent.LastName}\n\n\t\t\t\t\t\tPortal Dashboard");
                    Console.WriteLine();
                    Console.WriteLine($"\n\n\t\t1 : View information \n\n\t\t2 : View registered customers\n\n\t\t3 : View customer subscription history\n\n\t\t4 : Subscribe for customer\n\n\t\t5 : Cancel customer subscription\n\n\t\t6 : Delete a registered customer\n\n\t\t7 : Register a new customer\n\n\t\t8 : Exit");
                    Console.Write($"\n\t\t  : ");
                    string selection = Console.ReadLine();
                    Console.Write($"\n\t\tProccessing");
                    Security.PrintDotAnimation();

                    switch (selection)
                    {

                        case "1":
                            AgentAccess acessToAgentInfo = new AgentAccess();
                            acessToAgentInfo.ViewAgentInformation();
                            break;
                        case "2":
                            AgentAccess accesToRegisteredCustomers = new AgentAccess();
                            accesToRegisteredCustomers.ViewCustomersInformation();
                            break;
                        case "3":
                            
                            AgentAccess customerSubscriptionHistory = new AgentAccess();
                            customerSubscriptionHistory.ViewCustomerSubscriptionHistory();
                            break;
                        case "4":
                            AgentAccess customerSubscription = new AgentAccess();
                            customerSubscription.SubscribeForCustomer();
                            break;
                        case "5":
                            AgentAccess customerSubscriptionCancel = new AgentAccess();
                            customerSubscriptionCancel.CancelCustomerSubscription();
                            break;
                        case "6":
                            AgentAccess deleteCustomer = new AgentAccess();
                            deleteCustomer.RemoveCustomer();
                            break;
                        case "7":
                            AgentAccess registerCustomer = new AgentAccess();
                            registerCustomer.RegisterCustomer();
                            break;
                        case "8":
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                    //Console.Clear();
                }

            }


        }

        public static void AgentContinuation()
        {
            Console.WriteLine("\n\n\t\t1 : Home Menu\n\t\t2 : Logout\n\t\t3 : Exit");
            Console.Write($"\t\t  : ");
            string optionSelected = Console.ReadLine();
            Console.Write("\n\n\t\tProccessing");
            Security.PrintDotAnimation();
            switch (optionSelected)
            {
                case "1":
                    CurrentStage = 1;
                    break;
                case "2":
                    AgentAuthenticationDisplay.LoginScreen();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
            Console.Clear();


        }
    }
}
