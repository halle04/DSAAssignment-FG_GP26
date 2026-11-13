using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment.Tasks {



    [Serializable]
    public class Employee {
        public string Name;
        public int EmployeeId;
        public bool HasEngineRoomClearance;
        public string LastEntranceInEngineRoom;
        public string LastExitFromEngineRoom;


        [Serializable]
        public class EmployeeArray {
            public Employee[] employees;
        }

        [CreateAssetMenu(fileName = "Check Employees Task", menuName = "Check Employees Task")]
        public class newEmployee : Task {
            [SerializeField] TextAsset jsonFile;
            [SerializeField] private EmployeeUI employeeUI;

            public override void Execute() {
                Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text).employees;
                EmployeeRef.Instance.employeeUser = new Employee[employees.Length];

                EmployeeRef.Instance.employeeUser = employees;
            }
        }
    }
}
