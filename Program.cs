
    string sensortemperature, sensorpression, sensorrotation;

    Console.WriteLine("");
    Console.WriteLine("---- Bem-Vindo ao Simulador de Luz de Advertência ----");
    Console.ResetColor();

    Console.WriteLine();
    Console.WriteLine("Digite o estado de cada um dos sensores");
    Console.WriteLine();

    Console.WriteLine("[D]esativado ou [A]tivado");
    Console.WriteLine("Sensor de temperatura...:");
    sensortemperature = Console.ReadLine()!.ToUpper();

        if (sensortemperature == "A")
        {
            Console.WriteLine("Sensor de pressão.......: ");
            sensorpression = Console.ReadLine()!.ToUpper();

            if (sensorpression == "A")
            {
                Console.WriteLine("Sensor de rotação.......: ");
                sensorrotation = Console.ReadLine()!.ToUpper();
                Console.Clear();
                Console.WriteLine("---- Simulador de Luz de Advertência ----");
                Console.WriteLine();

                Console.WriteLine("[A]tivado, [D]esativado");

                Console.WriteLine($"Sensor de temeperatura.....: {sensortemperature}");
                Console.WriteLine($"Sensor de pressão..........: {sensorpression}");
                Console.WriteLine($"Sensor de rotação..........: {sensorrotation}");

                Console.WriteLine();

                Console.WriteLine("A luz de advertência estará ATIVADA");
            }

            if (sensorpression == "D")
            {
                Console.WriteLine("Sensor de rotação.......: ");
                sensorrotation = Console.ReadLine()!.ToUpper();

                if (sensorrotation == "D")
                {
                    Console.Clear();

                    Console.WriteLine("---- Simulador de Luz de Advertência ----");
                    Console.WriteLine();

                    Console.WriteLine("[A]tivado, [D]esativado");
                    Console.WriteLine();

                    Console.WriteLine($"Sensor de temeperatura.....: {sensortemperature}");
                    Console.WriteLine($"Sensor de pressão..........: {sensorpression}");
                    Console.WriteLine($"Sensor de rotação..........: {sensorrotation}");

                    Console.WriteLine();
                    Console.WriteLine("A luz de advertência estará ATIVADA");

                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("---- Simulador de Luz de Advertência ----");
                    Console.WriteLine();

                    Console.WriteLine("[A]tivado, [D]esativado");
                    Console.WriteLine();

                    Console.WriteLine($"Sensor de temeperatura.....: {sensortemperature}");
                    Console.WriteLine($"Sensor de pressão..........: {sensorpression}");
                    Console.WriteLine($"Sensor de rotação..........: {sensorrotation}");

                    Console.WriteLine();
                    Console.WriteLine("A luz de advertência estará DESATIVADA");

                }

            }
        }

if (sensortemperature == "D")
{
    Console.WriteLine("Sensor de temperatura desativado ou você escolheu uma opção inválida");
}