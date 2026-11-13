using System;
using System.Linq;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Alphabetical Sorting Task", menuName = "Sorting/Alphabetical Sorting Task")]
    public class AlphabeticalSortingTask : Task {
        public override void Execute() {
            if(EmployeeRef.Instance == null) {
                return;
            }

            if(EmployeeRef.Instance.employeeUser == null) {
                return;
            }

            EmployeeRef.Instance.employeeUser =
                EmployeeRef.Instance.employeeUser
                    .OrderBy(employee => employee.Name, StringComparer.OrdinalIgnoreCase)
                    .ToArray();

            Debug.Log("Employees sorted alphabetically.");
        }
    }
}
