using Environment.Tasks;
using System;
using UnityEngine;
using Utils;

//add
namespace Environment {

    [Serializable]
    public class Computer : MonoBehaviour, IInteractable {
        [SerializeField] public GenericQueue<Task> testTask = new GenericQueue<Task>();
        [SerializeField] private EmployeeUI employeeUI;

        public void OnInteract() {
            if(testTask.Queue.Count > 0)
                testTask.Peek().Execute();

            if(employeeUI != null) {
                employeeUI.OpenScreen();
            }
        }
    }
}
