//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик Pupil.
//В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil,
//BadPupil от класса базового класса Pupil и переопределите каждый из методов,
//    в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
//```

using System.Collections.Generic;

namespace TeachMeSkills.DotNet.Task9
{

    //Можно создать логику при который при создании учиника указываеться его enum Progres
    //от него зависит экземляр какого класса создаться
    class ClassRoom
    {
        private Pupil _pupil;
        public List<Pupil> Pupils { set; get; } = new List<Pupil>();

        public ClassRoom(Pupil pupil)
        {
            _pupil = pupil;
        }

        public void AddPupil()
        {
            Pupils.Add(_pupil);
        }
        public void DelPupulic()
        {
            Pupils.Remove(_pupil);
        }
        public void SwohAllPupil()
        {
            foreach (var pupil in Pupils)
            {
                
            }
        }
    }
}

