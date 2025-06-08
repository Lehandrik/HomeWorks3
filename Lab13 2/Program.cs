namespace Lab13_2
{
    // Делегат для события изменения состояния устройства
    public delegate void DeviceStateChangedHandler(string deviceType, string newState, DateTime changeTime);

    public class SmartHomeSystem
    {
        private List<string> _devices = new List<string> { "Light", "Thermostat", "Door" };
        private bool _lightState;
        private int _currentTemperature;
        private bool _doorLocked;

        // Событие изменения состояния устройства
        public event DeviceStateChangedHandler DeviceStateChanged;

        public SmartHomeSystem()
        {
            _lightState = false;
            _currentTemperature = 20; // начальная температура
            _doorLocked = false; // дверь изначально заблокирована
        }

        // Методы управления светом
        public void TurnOnLight()
        {
            _lightState = true;
            OnDeviceStateChanged("Light", "Включен");
        }
        public void TurnOffLight()
        {
            _lightState = false;
            OnDeviceStateChanged("Light", "Выключен");
        }

        // Метод управления термостатом
        public void SetTemperature(int newTemp)
        {
            _currentTemperature = newTemp;
            OnDeviceStateChanged("Thermostat", $"Температура изменена на {newTemp}°C");
        }

        // Методы управления дверью
        public void LockDoor()
        {
            _doorLocked = true;
            OnDeviceStateChanged("Door", "Заблокирована");
        }
        public void UnlockDoor()
        {
            _doorLocked = false;
            OnDeviceStateChanged("Door", "Разблокирована");
        }

        // Метод для вызова события
        protected virtual void OnDeviceStateChanged(string deviceType, string newState)
        {
            DeviceStateChanged?.Invoke(deviceType, newState, DateTime.Now);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var smartHome = new SmartHomeSystem();

            // Подписываемся на событие изменения состояния
            smartHome.DeviceStateChanged += (deviceType, newState, changeTime) =>
            {
                Console.WriteLine($"[{changeTime:HH:mm:ss}] {deviceType}: {newState}");
            };

            // Имитация работы умного дома
            smartHome.TurnOnLight();
            smartHome.SetTemperature(23);
            smartHome.LockDoor();

            Console.ReadKey();
        }
    }
}
