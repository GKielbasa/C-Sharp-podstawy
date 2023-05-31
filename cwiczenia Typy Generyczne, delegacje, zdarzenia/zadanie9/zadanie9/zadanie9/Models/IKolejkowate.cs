using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9.Models
{
    internal interface IKolejkowate<T>
    {
        void Dodaj(T item);
        void Usun(); // zastosujemy sie do zasady CQS i nie bedziemy zwracac elementu z kolejki jezeli w zdaniu bedzie wymage dostosowanie metody do stacku zrobie Dequeue osobno
        T Pierwszy();
    }
}
