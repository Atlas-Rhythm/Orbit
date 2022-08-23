namespace DefaultNamespace {
    using Atlas.Orbit.Attributes;
    using Atlas.Orbit.Components;
    using System;
    using System.Collections.Generic;

    public class DynamicListTestView : OrbitView {
        [ValueID] private List<object> strings = new();
        [ValueID] private string enteredText = "";
        [EventEmitter("RefreshList")] private Action RefreshList;

        [ListenFor("RemoveString")]
        private void RemoveString(string str) {
            strings.Remove(str);
            RefreshList();
        }

        [ListenFor("AddString")]
        private void AddString() {
            strings.Add(enteredText);
            RefreshList();
        }
    }
}