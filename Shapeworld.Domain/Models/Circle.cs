using System;
namespace ShapeWorld.Domain.Models
{
  public class Circle : Shape
  {
    public virtual double Radius{ get; set; }

    public override double Perimeter()
    {
      return 2 * Radius * Math.PI;
    }

    public override double Surface()
    {
      return Math.PI * Radius * Radius;
    }

    public new double Volume(){
      return 1234;
    }

    public Circle() : base(0){
    }

  }
}