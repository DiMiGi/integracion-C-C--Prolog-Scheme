(library (SchemeLibraries punto)
         (export punto2 punto3 
                 punto? puntosSimilares? puntosIguales? 
                 adyacente? puntoPertenece? estaEnBordes?
                 getX getY getT
                 setX setY setT
                 puntoRandom creaAdyacente definirEnBorde
                 null
                 )
         (import (rnrs) (ironscheme) (ironscheme random))
         
		 #| definicion de la representacion nula (null) |#
         
		 (define null '())
		 #| 
			| punto2 recive dos numeros y crea un punto con esos numeros y un tercero
			| con el trofeo entre 0 y 9, 0 no posee trofeo y entre 1 y 9 posee un tipo de trofeo 
		 |#
         (define (punto2 x y)
           (if (and (number? x) (number? y))
               (list x y (if (= 0 (random 5)) (+ 1 (random 9)) 0))
               null
               )
           )
         
         #| 
			| punto3 recive tres numeros y crea un punto con esos numeros 
		 |#
		 
         (define (punto3 x y t)
           (if (and (and (number? x) (number? y)) (number? t))
               (list x y t)
               null
               )
           )
        
         #| 3.- representacion de pertenencia (Es un elemento de dominio en este caso un punto) |#
        
		 #| 
			| punto verifica que x sea un punto.
			| no se necesita la verificacion del tercer elemento puesto que siempre es un numero 
		 |#
		 
         (define (punto? x)
           (if (list? x) 
               (if (= (length x) 3)
                   (if (number? (car x))
                       (number? (car(cdr x)))
                       #f
                       )
                   #f
                   )
               #f
               )
           )
         
         #| Funcion que entrega como resultado verdadero (#t) si dos puntos coinciden en las coordenadas 'x' e 'y' |#
         (define (puntosSimilares? x y)
           (if (and (punto? x) (punto? y))
               (and (= (getX x) (getX y)) (= (getY x) (getY y)))
               #f
               )
           )
         
         #| Funcion que entrega como resultado verdadero (#t) si dos puntos coinciden en las coordenadas 'x' e 'y' y ademas en el tipo de trofeo |#
		 
         (define (puntosIguales? x y)
           (if (and (punto? x) (punto? y))
               (if (and (= (getX x) (getX y)) (= (getY x) (getY y)))
                   (= (getT x) (getT y))
                   #f
                   )
               #f
               )
           )
         
         
         #| Funcion que entrega como resultado verdadero (#t) si dos puntos son adyacentes entre si |#
		 
         (define (adyacente? x y) 
           (if (and (punto? x) (punto? y))
               (if (puntosSimilares? x y) 
                   #f
                   (if (or (= (+ (getX x) 1) (getX y)) (= (- (getX x) 1) (getX y)))
                       (= (getY x) (getY y))
                       (if (or (= (+ (getY x) 1) (getY y)) (= (- (getY x) 1) (getY y)))
                           (= (getX x) (getX y))
                           #f
                           )
                       )
                   )
               )
           )
         
         
         #|  verifica que el punto pertenezca a las dimensiones establecidas  |#
		 
         (define (puntoPertenece? punto dimX dimY)
           (if (punto? punto)
               (if (and (< (getX punto) dimX) (> (getX punto) -1))
                   (and (< (getY punto) dimY) (> (getY punto) -1))
                   #f
                   )
               #f
               )
           )
         
         
         #| funcion que determina si el punto x esta en los bordes de una matriz de dimensiones especificadas |#
		 
         (define (estaEnBordes? x dimX dimY)
           (if (punto? x)
               (if (or (= (getX x) 0) (= (getX x) (- dimX 1)))
                   #t
                   (or (= (getY x) 0) (= (getY x) (- dimY 1)))
                   )
               #f
               )
           )
         
         #| 4.- selectores |#
         
         #| Funcion que entrega el valor correspondiente a la coordenada 'x' de un punto |#
         (define (getX mPunto)
           (if (punto? mPunto)
               (car mPunto)
               null
               )
           )
         
         #| Funcion que entrega el valor correspondiente a la coordenada 'y' de un punto |#
		 
         (define (getY mPunto)
           (if (punto? mPunto)
               (car(cdr mPunto))
               null
               )
           )
         
         #| Funcion que entrega el valor correspondiente al tipo de trofeo de un punto |#
		 
         (define (getT mPunto)
           (if (punto? mPunto)
               (car(cdr(cdr mPunto)))
               null
               )
           )
         
         #| 5.- Modificadores |#
         
		 #| Funcion que "modifica" la coordenada x de un punto |# 
		 
         (define (setX mPunto x)
           (if (punto? mPunto)
               (punto3 x (getY mPunto) (getT mPunto))
               null
               )
           )
         #| Funcion que "modifica" la coordenada y de un punto |# 
         
         (define (setY mPunto y)
           (if (punto? mPunto)
               (punto3 (getX mPunto) y (getT mPunto))
               null
               )
           )
		   
		  #| Funcion que "modifica" el trofeo de un punto |# 
         
         (define (setT mPunto t)
           (if (punto? mPunto)
               (punto3 (getX mPunto) (getY mPunto) t)
               null
               )
           )
         
         #| 6.- Funciones de operacion |#
         
		 #| Funcion que genera un punto random dadas las dimensiones con trofeo igual a 0 |#
		 
         (define (puntoRandom dimX dimY)
           (punto3 (random dimX) (random dimY) 0)
           )
		   
         #| Funcion que crea un adyacente del nodo en las dimensiones dadas |#
         
		 (define (creaAdyacente nodo dimX dimY)
           (define (randAdyacencia)
             (define rand (random 4))
             (if (and (= rand 0) (= (getX nodo) 0))
                 (randAdyacencia)
                 (if (= rand 0)
                     rand
                     (if (and (= rand 1) (= (getY nodo) 0))
                         (randAdyacencia)
                         (if (= rand 1)
                             rand
                             (if (and (= rand 2) (= (getX nodo) (- dimX 1)))
                                 (randAdyacencia)
                                 (if (= rand 2)
                                     rand
                                     (if (= (getY nodo) (- dimY 1))
                                         (randAdyacencia)
                                         rand
                                         )
                                     )
                                 )
                             )
                         )
                     )
                 )
             )
           (define rand (randAdyacencia))
           (if (puntoPertenece? nodo dimX dimY)
               (if (= rand 0) 
                   (setT (setX nodo (- (getX nodo) 1)) (if (= 0 (random 5)) (+ 1 (random 9)) 0))
                   (if (= rand 1)
                       (setT (setY nodo (- (getY nodo) 1)) (if (= 0 (random 5)) (+ 1 (random 9)) 0))
                       (if (= rand 2)
                           (setT (setX nodo (+ (getX nodo) 1)) (if (= 0 (random 5)) (+ 1 (random 9)) 0))
                           (setT (setY nodo (+ (getY nodo) 1)) (if (= 0 (random 5)) (+ 1 (random 9)) 0))
                           )
                       )
                   )
               #f
               )
           )
         
         #| funcion que retorna un punto aleatorio que pertenece a los bordes de la matriz de dimensiones N y M |#
		 
         (define (definirEnBorde N M) 
           (define rand (puntoRandom N M))
           (if (estaEnBordes? rand N M) 
               rand
               (definirEnBorde N M)
               )
           )
         )