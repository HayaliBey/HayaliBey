﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public bool Length { get; internal set; }

        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi
            items = new T[items.Length+1]; //dizinin eleman sayısını 1 artırdım.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
