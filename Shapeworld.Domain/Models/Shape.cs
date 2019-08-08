namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
      //fields
      //Private fields are called backing fields
      //private int numberOfEdges;
      
      //properties
      public int NumberOfEdges {get;}

      //methods

      public virtual double Perimeter(){
        return 0;
      }

       public Shape(int edges)
      {
        NumberOfEdges = edges;
      }

      public abstract double Surface();

      public double Volume()
      {
        return 0;
      }




      // public int GetEdges()
      // {
      //   return numberOfEdges;
      // }
      // public void SetEdges(int edges)
      // {
      //   if (numberOfEdges == 0)
      //   {
      //     numberOfEdges=edges;
      //   }
      // }


      //controllers

     

    }
}