using Environment.Tasks;
using System;
using UnityEngine;


//add
namespace Environment {
    [CreateAssetMenu(fileName = "ReadEmployeesTask", menuName = "Surveillance Tasks/Read Employees")]
    


    public class ReadEmployeesTask : Task {
        [SerializeField] private Task nextTask;
        [SerializeField] private TextAsset jsonFile = null;

        public override void Execute() {
            if(jsonFile == null) {
                return;
            }
            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employee;

            if(employees == null || employees.Length == 0) {
                Debug.LogWarning("No employees found in JSON file.");
                return;
            }

            foreach (Employee employee in employees) {
                Debug.Log("Name: " + employee.name + "\n" + "employeeId: " + employee.employeeId);

                if(employee.hasEngineRoomClearance) {
                    Debug.Log("Last entrance in engine room: " +
                  employee.lastEntranceInEngineRoom +
                  "\nLast exit from engine room: " +
                  employee.lastExitFromEngineRoom);
                }
            }
        }
    }
    [Serializable]
    public class EmployeeArray {
        public Employee[] employee;
    }
}
