public partial class GameEntity
{
    static readonly InteractiveComponent InteractiveComponent = new InteractiveComponent();

    public bool IsInteractive
    {
        get => HasComponent(GameComponentsLookup.Interactive);
        set
        {
            if (value != IsInteractive)
            {
                const int index = GameComponentsLookup.Interactive;
                if (value)
                {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                        ? componentPool.Pop()
                        : InteractiveComponent;

                    AddComponent(index, component);
                }
                else
                {
                    RemoveComponent(index);
                }
            }
        }
    }
}

public sealed partial class GameMatcher
{
    static Entitas.IMatcher<GameEntity> _matcherInteractive;

    public static Entitas.IMatcher<GameEntity> Interactive
    {
        get
        {
            if (_matcherInteractive == null)
            {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Interactive);
                matcher.ComponentNames = GameComponentsLookup.ComponentNames;
                _matcherInteractive = matcher;
            }

            return _matcherInteractive;
        }
    }
}
