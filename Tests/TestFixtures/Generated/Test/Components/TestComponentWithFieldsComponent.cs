//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public ComponentWithFields componentWithFields { get { return (ComponentWithFields)GetComponent(TestComponentLookup.ComponentWithFields); } }
    public bool hasComponentWithFields { get { return HasComponent(TestComponentLookup.ComponentWithFields); } }

    public void AddComponentWithFields(string newPublicField) {
        var index = TestComponentLookup.ComponentWithFields;
        var component = CreateComponent<ComponentWithFields>(index);
        component.publicField = newPublicField;
        AddComponent(index, component);
    }

    public void ReplaceComponentWithFields(string newPublicField) {
        var index = TestComponentLookup.ComponentWithFields;
        var component = CreateComponent<ComponentWithFields>(index);
        component.publicField = newPublicField;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentWithFields() {
        RemoveComponent(TestComponentLookup.ComponentWithFields);
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
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherComponentWithFields;

    public static Entitas.IMatcher<TestEntity> ComponentWithFields {
        get {
            if (_matcherComponentWithFields == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentLookup.ComponentWithFields);
                matcher.componentNames = TestComponentLookup.componentNames;
                _matcherComponentWithFields = matcher;
            }

            return _matcherComponentWithFields;
        }
    }
}