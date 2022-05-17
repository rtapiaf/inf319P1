# -*- coding: utf-8 -*-
"""
Created on Mon May 16 23:00:09 2022

@author: Ronald
"""
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("padre(juan,roberto)")
prolog.assertz("padre(juan,julio)")

prolog.assertz("padre(julio,antonio)")

prolog.assertz("padre(roberto,sara)")

#prolog.assertz("hermano(A,B):-padre(P,A),padre(P,B)")
prolog.assertz("abuelo(A,N):-padre(A,P),padre(P,N)")
prolog.assertz("nieto(N,A):-padre(P,N),padre(A,P)")
prolog.assertz("primo(M,N):-nieto(M,A),nieto(N,A)")
#prolog.assertz("primo(A,B):-padre(M,A),padre(N,B),hermano(M,N)")

for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es el abuelo de ",elemento["Y"])

for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"], "es el nieto de ",elemento["Y"])
    
for elemento in prolog.query("primo(X,Y)"):
    print(elemento["X"], "es el primo de ",elemento["Y"])
