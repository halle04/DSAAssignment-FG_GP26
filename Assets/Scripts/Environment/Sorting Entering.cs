using System;
using System.Linq;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Entrance Time Sorting Task", menuName = "Sorting/Entrance Time Sorting Task")]
    public class EntranceTimeSortingTask : Task {
        public override void Execute() {
            if(EmployeeRef.Instance == null) {
                return;
            }

            if(EmployeeRef.Instance.employeeUser == null) {
                return;
            }

            EmployeeRef.Instance.employeeUser =
                EmployeeRef.Instance.employeeUser
                    .OrderBy(employee => {
                        DateTime entranceTime;

                        bool validDate = DateTime.TryParse(
                            employee.LastEntranceInEngineRoom,
                            out entranceTime
                        );

                        return validDate ? entranceTime : DateTime.MaxValue;
                    })
                    .ToArray();

            Debug.Log("Employees sorted by engine room entrance time.");
        }
    }
}
