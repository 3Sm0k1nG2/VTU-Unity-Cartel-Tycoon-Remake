public class TierI : IResearch
{
    public string Name { get; }
    public string Description { get; }

    public short Cost { get; }
    public GameTimeDuration Duration { get; }
    public ResearchState State { get; private set; }

    public object[] Specifications { get; }

    public TierI()
    {
        Name = "Tier I";
        Description = Global.Instance.ResearchDescriptions.TIER_I;
        
        Cost = 0;
        Duration = new GameTimeDuration();
        State = ResearchState.Researched;

        Specifications = new object[0];
    }

    public void ChangeState(ResearchState state)
    {
        if (State + 1 != state) return;

        State = state;
    }
}
