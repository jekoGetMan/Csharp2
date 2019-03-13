using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Diagnostics;
using System.Net;

namespace tst
{

    //Животные
    class Animals
    {
        //Утка testik
        class Duck : Animals
        {

        }
        //Страус
        class mammals : Animals
        {

        }
        //Собака
        class artiodactyls : Animals
        {

        }
        //Кот
        class horse : artiodactyls
        {

        }
    }
}
