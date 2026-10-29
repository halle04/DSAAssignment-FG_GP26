using System;
using System.Linq;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Alphabetical Sorting Task", menuName = "Sorting/Alphabetical Sorting Task")]
    public class AlphabeticalSortingTask : Task {
        public override void Execute() {
            if(EmployeeRef.Instance == null) {
                Debug.LogError("EmployeeRef.Instance is null!");
                return;
            }

            if(EmployeeRef.Instance.employeeUser == null) {
                Debug.LogError("No employee data available to sort!");
                return;
            }

            EmployeeRef.Instance.employeeUser =
                EmployeeRef.Instance.employeeUser
                    .OrderBy(employee => employee.name, StringComparer.OrdinalIgnoreCase)
                    .ToArray();

            Debug.Log("Employees sorted alphabetically.");
        }
    }
}
