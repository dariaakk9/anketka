using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anketka
{
    public class Student : IDataErrorInfo
    {

        public string FIO { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(FIO) && string.IsNullOrWhiteSpace(FIO))
                    return "ФИО не может быть пустым";

                if (columnName == nameof(Age) && (Age < 15 || Age > 50))
                    return "Возраст должен быть от 15 до 50";

                if (columnName == nameof(Group) && string.IsNullOrWhiteSpace(Group))
                    return "Поле группа не может быть пустым";

                if (columnName == nameof(Course) && string.IsNullOrWhiteSpace(Course))
                    return "Поле курс не может быть пустым";
                return null;

            }
        }
    }
}
