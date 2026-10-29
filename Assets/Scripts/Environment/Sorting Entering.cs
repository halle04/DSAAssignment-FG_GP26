using System;
using System.Linq;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Entrance Time Sorting Task", menuName = "Sorting/Entrance Time Sorting Task")]
    public class EntranceTimeSortingTask : Task {
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
                    .OrderBy(employee => {
                        DateTime entranceTime;

                        bool validDate = DateTime.TryParse(
                            employee.lastEntranceInEngineRoom,
                            out entranceTime
                        );

                        return validDate ? entranceTime : DateTime.MaxValue;
                    })
                    .ToArray();

            Debug.Log("Employees sorted by engine room entrance time.");
        }
    }
}
