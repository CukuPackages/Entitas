public sealed partial class GameStateMatcher
{
    public static Entitas.IAllOfMatcher<GameStateEntity> AllOf(params int[] indexes) =>
        Entitas.Matcher<GameStateEntity>.AllOf(indexes);

    public static Entitas.IAllOfMatcher<GameStateEntity> AllOf(params Entitas.IMatcher<GameStateEntity>[] matchers) =>
        Entitas.Matcher<GameStateEntity>.AllOf(matchers);

    public static Entitas.IAnyOfMatcher<GameStateEntity> AnyOf(params int[] indexes) =>
        Entitas.Matcher<GameStateEntity>.AnyOf(indexes);

    public static Entitas.IAnyOfMatcher<GameStateEntity> AnyOf(params Entitas.IMatcher<GameStateEntity>[] matchers) =>
        Entitas.Matcher<GameStateEntity>.AnyOf(matchers);
}
