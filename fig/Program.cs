using System;
using System.Collections.Generic;

namespace Figura2
{
    class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    
    
    }
    abstract class Figura
    {
        public Vector2d position;
        public string fill ,border;

          //Constructor por defecto 
        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        //constructor de figura
        public Figura(Vector2d pos)
        {
            position= pos;
            fill= "white";
            border="white";
        }

        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
     }
    }
 
    class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2d pos):base(pos)
     {
         fill="black";
         border="pink";
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1} con borde color {2}", position, fill,border);
     }
    }
    class Triangulo : Figura
    {
     
     public Triangulo(Vector2d pos):base(pos)
     {
       fill="green";  
     }
     public Triangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Triangulo en {0} de color {1} con borde color {2}", position, fill,border);
     }
    }
    class Cuadrado : Figura
    {
     
     public Cuadrado(Vector2d pos):base(pos)
     {
         fill="bronw" ;
         border="black";
     }
     public Cuadrado ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Cuadrado en {0} de color {1} con borde color {2}", position, fill,border);
     }
    }
    class Trapecio : Figura
    {
     
     public Trapecio(Vector2d pos):base(pos)
     {
         fill="pink" ;
         border="black";
     }
     public Trapecio ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Trapecio en {0} de color {1} con borde color {2}", position, fill,border);
     }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2d(200,200) ));
            figuras.Add(new Triangulo(new Vector2d(50,125) ));
            figuras.Add(new Cuadrado(new Vector2d(101,24) ));
            figuras.Add(new Trapecio(new Vector2d(152,124) ));
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}
