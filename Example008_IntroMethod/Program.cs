﻿// 

int a1 = 15,
    b1 = 21,
    c1 = 39,
    a2 = 12,
    b2 = 23,
    c2 = 33,
    a3 = 12373,
    b3 = 23,
    c3 = 313;

    int max = a1;
    if(b1 > max) max = b1;
    if(c1 > max) max = c1;

    if(a2 > max) max = a2;
    if(b2 > max) max = b2;
    if(c2 > max) max = c2;

    if(a3 > max) max = a3;
    if(b3 > max) max = b3;
    if(c3 > max) max = c3;
  
  Console.WriteLine(max);