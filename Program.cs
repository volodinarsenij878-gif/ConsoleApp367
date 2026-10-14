using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main()
        { }
         // Перегрузка 1: штатное ступенчатое снижение скорости (по ссылке).
         // Перегрузка 2: экстренное торможение на уклоне с рекуперацией и возвратом тепла.
    public void ApplyMagneticBrake(ref double speedKmh, int powerStep)
        {
            // Штатное торможение
            speedKmh = 0.0; // Заглушка — в реальности расчёт
        }

        public void ApplyMagneticBrake(ref double speedKmh, double slopeAngle, bool emergencyRegen, out double heatKwh)
        {
            // Экстренное торможение с рекуперацией
            heatKwh = 0.0; // Заглушка — в реальности расчёт
        }
    }
}
