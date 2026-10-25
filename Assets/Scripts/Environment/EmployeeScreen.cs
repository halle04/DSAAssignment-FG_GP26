using UnityEngine;
using TMPro;

namespace Environment.Tasks {
    public class EmployeeScreen : MonoBehaviour {
        [SerializeField] private TMP_Text employeeText;

        public void SetEmployee(Employee employee) {
            string information =
                "Name: " + employee.name + "\n" +
                "ID: " + employee.employeeId + "\n" +
                "Engine Room Clearance: " +
                (employee.hasEngineRoomClearance ? "Yes" : "No");

            if(employee.hasEngineRoomClearance) {
                information +=
                    "\nLast Entrance: " +
                    employee.lastEntranceInEngineRoom +
                    "\nLast Exit: " +
                    employee.lastExitFromEngineRoom;
            }

            employeeText.text = information;
        }
    }
}
