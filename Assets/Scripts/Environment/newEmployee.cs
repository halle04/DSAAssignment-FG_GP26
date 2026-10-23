using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment.Tasks {
    [Serializable]
    public class Employee {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;
    }

    [Serializable]
    public class EmployeeArray {
        public Employee[] employees;
    }

    [CreateAssetMenu(fileName = "Check Employees Task", menuName = "Check Employees Task")]
    public class newEmployee : Task {
        [SerializeField] TextAsset jsonFile;

        public override void Execute() {
            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text).employees;
            EmployeeRef.Instance.employeeUser = new Employee[employees.Length];

            EmployeeRef.Instance.employeeUser = employees;
        }
    }
}
