namespace DesignPatterns.Mediator
{
  class  Aircraft
  {
    public string Name;
    public int Size { get; set; }
    
    public CommandCentre commandCentre;
    
    public bool IsTakingOff { get; set; }
    public Runway? CurrentRunway { get; set; }

    public Aircraft(string name, int size,CommandCentre commandCentre)
    {
      this.Name = name;
      this.Size = size;
      this.commandCentre = commandCentre;
    }
    
    public void Land(Runway runway)
    {
      commandCentre.LandPlane(runway,this);
    }
    public void TakeOff(Runway runway)
    {
      commandCentre.TakeOff(runway,this);
    }
  }
}
