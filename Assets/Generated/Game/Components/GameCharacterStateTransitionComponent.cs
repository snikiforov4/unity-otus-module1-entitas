//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CharacterStateTransitionComponent characterStateTransition { get { return (CharacterStateTransitionComponent)GetComponent(GameComponentsLookup.CharacterStateTransition); } }
    public bool hasCharacterStateTransition { get { return HasComponent(GameComponentsLookup.CharacterStateTransition); } }

    public void AddCharacterStateTransition(CharacterState newValue) {
        var index = GameComponentsLookup.CharacterStateTransition;
        var component = (CharacterStateTransitionComponent)CreateComponent(index, typeof(CharacterStateTransitionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCharacterStateTransition(CharacterState newValue) {
        var index = GameComponentsLookup.CharacterStateTransition;
        var component = (CharacterStateTransitionComponent)CreateComponent(index, typeof(CharacterStateTransitionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCharacterStateTransition() {
        RemoveComponent(GameComponentsLookup.CharacterStateTransition);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCharacterStateTransition;

    public static Entitas.IMatcher<GameEntity> CharacterStateTransition {
        get {
            if (_matcherCharacterStateTransition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CharacterStateTransition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharacterStateTransition = matcher;
            }

            return _matcherCharacterStateTransition;
        }
    }
}
