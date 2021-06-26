using System; 

class URI {

    static void Main(string[] args) { 

        double[] arraylist = new double[2];
        double x, y;

        Console.WriteLine("Informe as coordenadas de um ponto (exemplo: 4,5 -2,2): ");
        string [] cordenadas = Console.ReadLine().Split();
        x = double.Parse(cordenadas[0]);
        y = double.Parse(cordenadas[1]);

        if (x == 0.0 && y == 0.0)
        {
            Console.WriteLine();
            Console.WriteLine("Origem");        
        }
        else if (x == 0.0 && y != 0.0)
        {
            Console.WriteLine();
            Console.WriteLine("Eixo Y");              
        }
        else if (x != 0.0 && y == 0.0)
        {
            Console.WriteLine();
            Console.WriteLine("Eixo X");
        }
        else if (x > 0.0 && y > 0.0 )
        {
            Console.WriteLine();
            Console.WriteLine("Q1");            
        }
        else if (x < 0.0 && y > 0.0 )
        {
            Console.WriteLine();
            Console.WriteLine("Q2");            
        }                        
        else if (x < 0.0 && y < 0.0 )
        {
            Console.WriteLine();
            Console.WriteLine("Q3");            
        }    
        else 
        {
            Console.WriteLine("Q4");            
        }    
    }  
}
