(library (SchemeLibraries laberinto)
         (export createMaze checkMaze createRouteLow
                 getInicio getFinal getDimX getDimY
                 getParametros getLaberinto)
         (import (rnrs) (SchemeLibraries punto))
         
         
         #|
			| representacion de la generacion automatica
          	| '('('(Inicio)'(Final) DimX DimY) '('(Final)'()'() ... '()'(Inicio)))
			| una coordenada esta dada por '(x y t) donde x es la coord. x y la coord y y t el trofeo 0 no tiene cualquier otro si tiene
         |#
		 
         #| Constructor |#
         
		 #|
			| Crea un laberinto aleatorio definido como la representacion 
			| (((Inicio)(Final) DimX DimY) ((Final)(adyacente final) ... (adyacente inicio)(Inicio))) 
			| Entrada: Dimensiones del laberinto
			| Salida: laberinto con al menos 1 camino
		 |#
		 
         (define (createMaze N M)
			(define inicio (definirEnBorde N M))
			(define final (definirEnBorde N M)) 
			(define (crearLaberinto inicio final listaRet)
			(define adyacente (creaAdyacente inicio N M))
			(if (null? listaRet)
                 (crearLaberinto adyacente final (list inicio))
                 (if (puntosSimilares? inicio final)
                     (cons final listaRet)
                     (crearLaberinto adyacente final (cons inicio listaRet))
                     )
                 )
             )
           (if (number? N) 
               (if (number? M)
                   (if (puntosSimilares? inicio final)
                       (createMaze N M)
                       (list (list inicio final N M) (crearLaberinto inicio final '()))
                       )
                   #f
                   )
               #f
               )
           )
         
         #| Funcion que obtiene el inicio del laberinto |#
         
         (define (getInicio L)
           (caar L)
           )
		   
		   #| Funcion que obriene el final del laberinto |#
         
         (define (getFinal L)
           (car(cdr(car L)))
           )
         
		 
		 #| Funcion que obtiene la dimension X del laberinto |#
		         
         (define (getDimX L)
           (car(cdr(cdr(getParametros L))))
           )
         
		 
		 #| Funcion que obtiene la dimension Y del laberinto |#
		 
         (define (getDimY L)
           (car(cdr(cdr(cdr(getParametros L)))))
           )
         
		 
		 #| Funcion que obtiene los parametros del laberintos correspondientes al inicio final y dimensiones |#
		 
         (define (getParametros L)
           (car L)
           )
         
		 
		 #| Funcion que obtiene la representacion del laberinto sin los parametros |#
		 
         (define (getLaberinto L)
           (car(cdr L))
           )
         
         
		 #| Modificadores |#
         
         #| funciones de pertenencia |#
         
		 #| Funcion que valida que el laberinto sea valido, es decir cumple con el formato de la representacion |#
         (define (checkMaze L)
           (define inicio (getInicio L))
           (define final (getFinal L))
           (define (verificarLaberinto L inicio final dimX dimY)
             (if (puntoPertenece? final dimX dimY)
                 (if (null? L)
                     (puntosIguales? inicio final)
                     (if (adyacente? (car L) final) 
                         (verificarLaberinto (cdr L) inicio (car L) dimX dimY)
                         #f
                         )
                     )
                 #f
                 )
             )
           (if (null? L)
               #f
               (if (and (= 2 (length L)) (= 4 (length (getParametros L))))
                   (if (and (punto? inicio) (punto? final))
                       (if (puntosIguales? (car (getLaberinto L)) final)
                           (if (and (puntoPertenece? inicio (getDimX L) (getDimY L)) 
									(puntoPertenece? final (getDimX L) (getDimY L)))
                               (verificarLaberinto (cdr (getLaberinto L)) inicio final (getDimX L) (getDimY L))
                               #f
                               )
                           #f
                           )
                       #f
                       )
                   #f
                   )
               )
           )
         
         
		 #| Funcion que valida si el punto existe en laberinto como lista |#
		 
         (define (existeEnLista? punto laberinto)
             (if (null? laberinto)
                 #f
                 (if (puntosSimilares? (car laberinto) punto)
                     #t
                     (existeEnLista? punto (cdr laberinto))
                     )
                 )
             )
         
		 
		 #| Funcion que valida si el punto existe en la representacion del laberinto establecida |#
		 
         (define (existeEnLaberinto? punto lab)
           (if (null? lab)
               #f
               (existeEnLista? punto (car(cdr lab)))
               )
           )
         
		 
		 #| Funcion que quita el punto de la lista  no implementado|#
		
		#| 
			|funciones de operaciones 
		|#
         
         (define (quitarPuntoDeLista punto lista)
           (define listaAux '())
           (define (ejecutar punto lista listaAux)
             (if (null? lista)
                 listaAux
                 (if (puntosIguales? (car lista) punto)
                     (ejecutar punto (cdr lista) listaAux)
                     (ejecutar punto (cdr lista) (cons (car lista) listaAux))
                     )
                 )
             )
           (ejecutar punto lista listaAux)
           )
         
		 
		 #| Funcion que invierte la lista L no implementado|#
		 
         (define (invertirLista L)
           (quitarPuntoDeLista '() L)
           )
         

		 #| Funcion que obtiene adyacentes del punto en el laberinto no implementado|#
		 
         (define (obtenerAdyacentes punto laberinto)
           (define (ejecutar punto listaAux adyacentes)
             (if (null? listaAux)
                 adyacentes
                 (if (adyacente? (car listaAux) punto)
                     (if (existeEnLista? (car listaAux) adyacentes)
                         (ejecutar punto (cdr listaAux) adyacentes)
                         (ejecutar punto (cdr listaAux) (cons (car listaAux) adyacentes))
                         )          
                     (ejecutar punto (cdr listaAux) adyacentes)
                     )                     
                 )
             )
           (if (checkMaze laberinto)
               (ejecutar punto (getLaberinto laberinto) '())
               #f
               )
           )
         

		  #|
				|funcion que desde el punto P busca un camino de largo T en el laberinto L
		  |#
         (define (createRouteLow L P T)
           (define (crearRuta almacenamientoRuta puntoActual tamanioActual adyacentesRevisados)
             (define adyacente (creaAdyacente puntoActual (getDimX L) (getDimY L)))
               (if (> tamanioActual 1)
                   (if (= adyacentesRevisados 0)
                       (invertirLista almacenamientoRuta)
                       (if (and (existeEnLaberinto? adyacente L) (not (existeEnLista? adyacente almacenamientoRuta)))
                           (crearRuta (cons adyacente almacenamientoRuta) adyacente (- tamanioActual 1) 4)
                           (crearRuta almacenamientoRuta puntoActual tamanioActual (- adyacentesRevisados 1))
                           )
                       )
                   (invertirLista almacenamientoRuta)
                   )
               )
             (if (existeEnLaberinto? P L)
                 (crearRuta (list P) P T 4)
                 #f
                 )
             )
           )