////using Environment.Tasks;
////using System;
////using UnityEngine;


//////add
////namespace Environment {
////    [CreateAssetMenu(fileName = "ReadEmployeesTask", menuName = "Surveillance Tasks/Read Employees")]

////    [Serializable]
////    public class Employee {
////        public string name;
////        public int employeeId;
////        public bool hasEngineRoomClearance;
////        public string lastEntranceInEngineRoom;
////        public string lastExitFromEngineRoom;
////    }

////    [Serializable]
////    public class EmployeeArray {
////        public Employee[] employee;
////    }

////    public class ReadEmployeesTask : Task {
////        [SerializeField] private Task nextTask;
////        [SerializeField] private TextAsset jsonFile;
////        public override void Execute() {
////            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text).employee;
////            EmployeeRef.Instance.Employees = new Employee[employees.Length];
////            EmployeeRef.Instance.Employees = employees;

//            // save this somewhere to call it
//            //Employee[] employee = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employee;

//            //if(EmployeeRef.Instance.Employees == null || EmployeeRef.Instance.Employees.Length == 0) {
//            //    Debug.LogWarning("No employees found in JSON file.");
//            //    return;
//            //}

//            //Array.Sort(employee, (a, b) => DateTime.Compare(DateTime.Parse(b.lastEntranceInEngineRoom),DateTime.Parse(a.lastEntranceInEngineRoom)));

//            //foreach (Employee en in employees)
//            //{
//            //    //Debug.Log("Name: " + e.name + "\n" + "employeeId: " + e.employeeId);




//            //    //if(e.hasEngineRoomClearance) {
                    
//            //    //    Debug.Log("Last entrance in engine room: " +
//            //    //  e.lastEntranceInEngineRoom +
//            //    //  "\nLast exit from engine room: " +
//            //    //  e.lastExitFromEngineRoom);
                   

//            //}
//        }
//    }

//}
