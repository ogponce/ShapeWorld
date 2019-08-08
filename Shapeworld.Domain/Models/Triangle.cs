namespace ShapeWorld.Domain.Models
{
  public class Triangle : Shape 
  {
    public virtual double Length{ get; set; }

    public virtual double Width{ get; set; }

    public virtual double Height{ get; set; }

    public override double Perimeter()
    {
      return Length + Width + Height;
    }

    public override double Surface()
    {
      return 0.5 * Length * Width;
    }

    public new double Volume(){
      return 1234;
    }

    public Triangle() : base(3){
    }



  }
}