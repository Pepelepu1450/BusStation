using System;
using System.Collections.Generic;

namespace bus_station
{
    class Menu
    {
        /*

        1) ingreso
        2) salida de camiones 
        3) exportar
        4) ver estadisticas
        5) borrar

        9) salir

        */

        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 9 });

        List<AutoBus> ListaDeAutoBuses = new List<AutoBus>();

        private void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("¡Bienvenido Humano!");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions()
        {
            System.Console.WriteLine("1) ingreso");
            System.Console.WriteLine("2) salida");
            System.Console.WriteLine("3) exportar");
            System.Console.WriteLine("4) ver estadisticas");
            System.Console.WriteLine("5) borrar info");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage()
        {
            System.Console.WriteLine("¡Gracias por su preferencia! ¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida
            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        private void IngresoDeCamion()
        {
            System.Console.WriteLine("ingresa el nombre del camionero:");
            string nombreIngresado = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("ingresa la ruta");
            char rutaIngresada = Convert.ToChar(Console.ReadLine());

            ListaDeAutoBuses.Add(new AutoBus(nombreIngresado, rutaIngresada));

            System.Console.WriteLine($"se ingreso con exito el conductor {nombreIngresado} con la ruta {rutaIngresada}");
        }

        private void SalidaDeCamion(){
            System.Console.WriteLine("to do salida de camion");
        }

        private void Exportar(){
            
            if (ListaDeAutoBuses.Count <= 0)
            {
                System.Console.WriteLine("no existen camiones");
            }
            else 
            {
                System.Console.WriteLine("camines en espera:");
            }
            for (int i = ListaDeAutoBuses.Count - 1; i >= 0 ; i--)
            {
                System.Console.WriteLine($"conductor {ListaDeAutoBuses[i].tomarNombreDelConductor()}");
            }
        }

        private void VerEstadisticas(){
            System.Console.WriteLine("to do ver estadisticas");
        }

        private void borrarInfo(){
            System.Console.WriteLine("to do borrar info");
        }

        public void Display()
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1:
                        IngresoDeCamion();
                        break;

                    case 2:
                        SalidaDeCamion();
                        break;

                    case 3:
                        Exportar();
                        break;

                    case 4:
                        VerEstadisticas();
                        break;

                    case 5:
                        borrarInfo();
                        break;
                }
            }

            DisplayByeMessage();

        }

    }
}