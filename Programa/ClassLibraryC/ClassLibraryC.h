
	#include <stdio.h>
	#include <stdlib.h>
	#include <string.h>

	enum Corrupciones{CONFIG = 0,GAMEHISTORY = 1,SAVE = 2};
	
	/*!
		*	\enum Vector2
		*  \brief Enumeracion que comprueba los errores de lectura y escritura del archivo.
		*/
	enum StatusCode{
		OK,
		ERR_FILE_NOT_FOUND,
		ERR_FILE_NOT_PERMISSION
	};
	
	/*!
		 *	\struct Vector2
		 *  \brief Estructura que define las posiciones de un personaje.
		 */
		typedef struct Vector2{
			int x;//!< Posicion en el eje x, o la columna de la matriz.
			int y;//!< Posicion en el eje y, o la fila de la matriz.
		}Vector2;
	
		/*!
		 *	\struct Movimiento
		 *  \brief Estructura que define el movimiento del personaje.
		 */
		typedef struct Movimiento{
			int tipoDeMovimiento;//!< Indica si es un ataque o movimiento.
			Vector2 direccionDelMovimiento;//!< Indica posicion donde atacar o donde moverse.
		}Movimiento;
		/*!
		 *	\struct Trofeo
		 *  \brief Estructura que define los trofeos del juego.
		 */
		typedef struct Trofeo{
			char* nombre;//!< Indica el nombre del trofeo.
			int ID;//!< Indica el ID del trofeo.
			char* descipcion;//!< Indica una pequeña descripcion del trofeo.
			int habilidad;//!< Indica una habilidad asociada al trofeo.
		}Trofeo;
		/*!
		 *	\struct Jugador
		 *  \brief Estructura que define a un jugador.
		 */
		typedef struct Jugador{
			char* alias;//!< Indica el nombre del jugador.
			int ID;//!< Indica el ID del trofeo.
			//POSIBLES IMPLEMENTACIONES POSTERIORES
			int largoMovimientos;
			Movimiento* movimientos; // posiciones del jugador a lo largo del ultimo juego ademas de sus ataques
			int vidas; // vidas o una vida total del jugador
			int puntaje; // puntaje o en otro caso la experiencia del jugador
			int largoTrofeosRecolectados;
			Trofeo* trofeosRecolectados; // trofeos del jugador
			int largoDePuntuaciones;
			int *mejorPuntuacion; // mejores puntuaciones alcanzadas
			int largoDeAmigos;
			int* idAmigos; // SE IMPLEMENTARÁ EN EL CASO DE SER MULTIJUGADOR
		}Jugador;
		/*!
		 *	\struct Enemigo
		 *  \brief Estructura que define a un enemigo.
		 */
		typedef struct Enemigo{
			char* alias;//!< Indica el nombre del enemigo.
			int ID;//!< Indica el ID del enemigo.
			Movimiento* movimientos;//!< Indica los movimientos a lo largo del juego.
			int vidas;//!< Indica la cantidad de vida del enemigo
			Jugador* jugadores;//!< Indica los jugadores a los cuales debe atacar
		}Enemigo;
	
		/*!
		 *	\struct ConfigParam
		 *  \brief Estructura que define las configuraciones del juego.
		 */
		typedef struct ConfigParam{
			char* clave;//!< Indica el nombre de la configuracion.
			char* valor;//!< Indica el valor de la configuracion.
		}ConfigParam;
		/*!
		 *	\struct GameHistory
		 *  \brief Estructura que define la posibilidad de replicar todas las acciones realizadas en el ultimo juego.
		 */
		typedef struct GameHistory{
			int cantidadDeJugadores;//!< Indica el nombre del trofeo.
			int cantidadDeEnemigos;//!< Indica el nombre del trofeo.
			Jugador* jugadores;//!< Indica los jugadores en la ultima partida.
			Enemigo* enemigos;//!< Indica los enemigos en la ultima partida.
			int mapaID;//!< Indica el ID del mapa.
		}GameHistory;
	
		/*!
		 *	\struct SaveGame
		 *  \brief Estructura que define los elementos que se necesitan para cargar las ultima posicion de un jugador.
		 */
		typedef struct SaveGame{
			char* nombreArchivo;//!< Indica el nombre del archivo guardado.
			Jugador jugador;//!< Indica el jugador que se va a guardar.
			int mapaID; //!< Indica el id del mapa que se guardara.
		}SaveGame;
				
		#define DLL_EXP __declspec(dllexport)
		#define CALL __stdcall

		extern "C" DLL_EXP void CALL  encriptar(char*,char*);
		extern "C" DLL_EXP void CALL desencriptar(char*,char*);
		extern "C" DLL_EXP int CALL confirmarCorrupcion(char*,char*,char*);
		extern "C" DLL_EXP int CALL detectarCorrupcion(char*,int,char*);
		extern "C" DLL_EXP void CALL medidasDeCorrupcion();
		extern "C" DLL_EXP void CALL loadSettings(char*,ConfigParam**, int*,int*);
		extern "C" DLL_EXP void CALL saveSettings(char*,ConfigParam*, int length,int*);	
		extern "C" DLL_EXP void CALL loadGameHistory(char*,GameHistory*,int*);
		extern "C" DLL_EXP void CALL saveGameHistory(char*,GameHistory,int*);
		extern "C" DLL_EXP void CALL loadSavedGame(char*,SaveGame**,int*,int*);
		extern "C" DLL_EXP void CALL saveGame(char*,SaveGame*,int,int*);


