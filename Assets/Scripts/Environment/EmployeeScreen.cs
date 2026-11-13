using UnityEngine;
using TMPro;

namespace Environment.Tasks {
    public class EmployeeScreen : MonoBehaviour {
        [SerializeField] private TMP_Text employeeText;

        public void SetEmployee(Employee employee) {
            string information =
                "Name: " + employee.Name + "\n" +
                "ID: " + employee.EmployeeId + "\n" +
                "Engine Room Clearance: " +
                (employee.HasEngineRoomClearance ? "Yes" : "No");

            if(employee.HasEngineRoomClearance) {
                information +=
                    "\nLast Entrance: " +
                    employee.LastEntranceInEngineRoom +
                    "\nLast Exit: " +
                    employee.LastExitFromEngineRoom;
            }

            employeeText.text = information;
        }
    }
}
