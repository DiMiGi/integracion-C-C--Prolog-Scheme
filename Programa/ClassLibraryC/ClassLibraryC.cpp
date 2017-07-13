// Archivo DLL principal.

#include "stdafx.h"

#include "ClassLibraryC.h"



/*! \fn void encriptar(char* fileNameToRead,char* fileNameToWrite)
*	\brief encripta el archivo de texto de nombre indicado y crea un nuevo archivo con la encriptacion.
*	\param fileNameToRead nombre de archivo a leer.
*	\param fileNameToWrite nombre de archivo a escribir, si no existe se crea.
*/
DLL_EXP void CALL encriptar(char* fileNameToRead,char* fileNameToWrite){
	FILE* archivo;
	FILE* archivoTemp;
	char caracter;
	fopen_s(&archivo,fileNameToRead,"r");
	fopen_s(&archivoTemp,fileNameToWrite,"w");
	if(archivo!=NULL && archivoTemp!=NULL){
		do{
			caracter = fgetc(archivo);
			if(caracter!=EOF)fputc(caracter+5,archivoTemp);
		}while(caracter != EOF);
	}
	fclose(archivo);
	fclose(archivoTemp);
}
	
/*! \fn void desencriptar(char* fileNameToRead,char* fileNameToWrite)
	*  \brief desencripta el archivo de texto de nombre indicado y crea un nuevo archivo con la desencriptacion.
	*  \param fileNameToRead nombre de archivo a leer.
	*	\param fileNameToWrite nombre de archivo a escribir, si no existe se crea.
	*/
DLL_EXP void CALL desencriptar(char* fileNameToRead,char* fileNameToWrite){
	FILE* archivo;
	FILE* archivoTemp;
	char caracter;
	fopen_s(&archivo,fileNameToRead,"r");
	fopen_s(&archivoTemp,fileNameToWrite,"w");
	if(archivo!=NULL && archivoTemp!=NULL){
		do{
			caracter = fgetc(archivo);
			if(caracter!=EOF)fputc(caracter-5,archivoTemp);
		}while(caracter != EOF);
	}
	fclose(archivo);
	fclose(archivoTemp);
}
	
	/*!
*	\fn int confirmarCorrupcion(char* fileNameComparado,char* fileNameOriginal)
	*  \brief Comprueba que dos archivos sean exactamente iguales.
	*  \param fileNameComparado archivo que sera comparado.
	*  \param fileNameOriginal archivo que contiene los datos originales e encriptados.
	*	\param fileNameTemp nombre del archivo temporal que se creara.
	*	\return Retorna 1 si encuentra discrepancias y 0 si llega al final del archivo
	*/
DLL_EXP int CALL confirmarCorrupcion(char* fileNameComparado,char* fileNameOriginal,char* fileNameTemp){
	FILE* archivoComparado;
	FILE* archivoCopiaOriginal;
	int retorno;
	char caracterComparado = ' ',caracterOriginal = ' ';
	fopen_s(&archivoComparado,fileNameComparado,"r");
	desencriptar(fileNameOriginal,fileNameTemp);
	fopen_s(&archivoCopiaOriginal,fileNameTemp,"r");
	while(1){
		if(caracterComparado!=caracterOriginal){
			retorno = 1;
			break;
		}
		if(caracterComparado == EOF){
			retorno = 0;
			break;
		}
		caracterComparado = getc(archivoComparado);
		caracterOriginal = getc(archivoCopiaOriginal);
	}
	remove(fileNameTemp);
	fclose(archivoComparado);
	fclose(archivoCopiaOriginal);
	return retorno;
}
/*!
*	\fn int detectarCorrupcion(char* fileName,int tipoDeArchivo)
	*  \brief segun el archivo aplica la funcion confirmarCorrupcion correspondiente.
	*  \param fileName archivo que se evaluara la corrupcion.
	*  \param tipoDeArchivo arreglo de estructuras SaveGame, contiene las configuraciones.
	*	\param fileNameTemp nombre del archivo temporal que se creara.
	*	\return Retorna el valor entregado por la funcion confirmarCorrupcion, -1 en caso que no encuentre asignaciones validas.
	*/
DLL_EXP int CALL detectarCorrupcion(char* fileName,int tipoDeArchivo,char* fileNameTemp){
	int corrupto;
	switch(tipoDeArchivo){
		case CONFIG:
				corrupto = confirmarCorrupcion(fileName,"bin/configEncriptado.txt",fileNameTemp);	
			break;
		case GAMEHISTORY:
				corrupto = confirmarCorrupcion(fileName,"bin/gameHistoryEncriptado.txt",fileNameTemp);
			break;
		case SAVE:
				corrupto = confirmarCorrupcion(fileName,"bin/saveEncriptado.txt",fileNameTemp);
			break;
		default:
				corrupto = -1;
	}
	return corrupto;
}
/*!
*	\fn void medidasDeCorrupcion()
	*  \brief Aplica las medidas de corrupcion a los 3 archivos principales.
	*/
DLL_EXP void CALL medidasDeCorrupcion(){
	FILE* archivoConfig;
	FILE* archivoSave;
	FILE* archivoHistory;
	fopen_s(&archivoConfig,"config.txt","r");
	fopen_s(&archivoSave,"save.txt","r");
	fopen_s(&archivoHistory,"gameHistory.txt","r");
	if(archivoConfig == NULL){
		desencriptar("bin/configEncriptado.txt","config.txt");
	}else{
		if(detectarCorrupcion("config.txt",0,"configTemp.txt")){
			desencriptar("bin/configEncriptado.txt","config.txt");
		}
	}
		
	if(archivoSave == NULL){
		desencriptar("bin/saveEncriptado.txt","save.txt");
	}else{
		if(detectarCorrupcion("save.txt",1,"saveTemp.txt")){
			desencriptar("bin/saveEncriptado.txt","save.txt");
		}
	}
		
	if(archivoHistory == NULL){
		desencriptar("bin/gameHistoryEncriptado.txt","gameHistory.txt");
	}else{
		if(detectarCorrupcion("gameHistory.txt",2,"gameHistoryTemp.txt")){
			desencriptar("bin/gameHistoryEncriptado.txt","gameHistory.txt");
		}
	}
		
	fclose(archivoConfig);
	fclose(archivoSave);
	fclose(archivoHistory);	
}
	
	
/*! \fn void loadSettings(char* fileName,ConfigParam** paramsReaded,int* length,char* statusCode) 
	*  \brief carga la configuracion del archivo de configuraciones.
	*  \param fileName nombre de archivo a leer.
	*  \param paramsReaded direccion de memoria de un arreglo de estructuras ConfigParam, no posee memoria asignada.
	*	\param length largo de texto leido, es asignado en el procedimiento.
	*	\param statusCode parametro que indica si el procedimiento tuvo un error de lectura.
	*/
DLL_EXP void CALL loadSettings(char *fileName,ConfigParam* paramsReaded[], int *length,int *statusCode){
	FILE *settingsCargados;
	int cont;
	char ultimaLineaLeida[100];
	fopen_s(&settingsCargados,fileName,"r");
	*length = 0;
	if (settingsCargados == NULL){*statusCode = ERR_FILE_NOT_FOUND;}
	else{
		*statusCode = OK;
		while(1){
			if(fgetc(settingsCargados) == EOF)break;
			fgets(ultimaLineaLeida,100,settingsCargados);
			(*length)++;
		}
	}
	fclose(settingsCargados);

	*paramsReaded = (ConfigParam*) malloc(sizeof(ConfigParam) * (*length));

	for (cont = 0; cont < *length; cont++){
			(*paramsReaded)[cont].valor = (char*)malloc(sizeof(char)*50);	
			(*paramsReaded)[cont].clave = (char*)malloc(sizeof(char)*50);
		}
		fopen_s(&settingsCargados,fileName,"r");
	if (settingsCargados == NULL){*statusCode = ERR_FILE_NOT_FOUND;}
	else{
		*statusCode = OK;
		// reemplaza a while para ahorrar lineas de codigo en la variable cont
		for (cont = 0;cont<*length;cont++) 
		{	
	 		fscanf_s(settingsCargados,"%s %s\n",(*paramsReaded)[cont].clave,(*paramsReaded)[cont].valor);
			printf("cosa");
	 	}
	}
	fclose(settingsCargados);
}
	
/*! \fn void saveSettings(char *fileName,ConfigParam *paramsToWrite, int length,char *statusCode)
	*  \brief Guarda las configuraciones del juego en el documento de texto.
	*  \param fileName nombre de archivo a guardar.
	*  \param paramsToWrite arreglo de estructuras ConfigParam, donde se encuentran las configuraciones a escribir.
	*	\param length largo del arreglo de paramsToWrite.
	*	\param statusCode parametro que indica si el procedimiento tuvo un error de escritura.
	*/
DLL_EXP void CALL saveSettings(char *fileName,ConfigParam *paramsToWrite, int length,int *statusCode){
	FILE *settingsAEscribir;
	int cont;
	fopen_s(&settingsAEscribir,fileName,"w");
	if (settingsAEscribir == NULL){*statusCode = ERR_FILE_NOT_PERMISSION;}
	else{
		*statusCode = OK;
		for(cont = 0;cont<length;cont++){
			fprintf(settingsAEscribir,"%s %s\n",paramsToWrite[cont].clave,paramsToWrite[cont].valor);
		}
	}
	if(settingsAEscribir != NULL){
		fclose(settingsAEscribir);
		encriptar(fileName,"bin/configEncriptado.txt");
	}
}
	
	
	
/*!
*	\fn void loadGameHistory(char *fileName,GameHistory *gameHistoryReaded,int *statusCode)
	*  \brief Carga los movimientos de todas las jugadas del ultimo juego.
	*  \param fileName nombre del archivo a leer.
	*  \param gameHistoryReaded direccion de memoria de la estructura GameHistory, no posee memoria asignada.
	*	\param statusCode parametro que indica si el procedimiento tuvo un error en la lectura.
	*/
DLL_EXP void CALL loadGameHistory(char *fileName,GameHistory *gameHistoryReaded,int *statusCode){
	FILE *settingsCargados;
	char letra;
	fopen_s(&settingsCargados,fileName,"r");
	if (settingsCargados == NULL){*statusCode = ERR_FILE_NOT_FOUND;}
	else{
		*statusCode = OK;
	 	fscanf_s(settingsCargados,"%d %d %d",&gameHistoryReaded->cantidadDeJugadores,&gameHistoryReaded->cantidadDeEnemigos,&gameHistoryReaded->mapaID);
	 	gameHistoryReaded->jugadores = (Jugador*)malloc(sizeof(Jugador) * (gameHistoryReaded->cantidadDeJugadores));	
		gameHistoryReaded->enemigos = (Enemigo*)malloc(sizeof(Enemigo) * (gameHistoryReaded->cantidadDeEnemigos));
		while(1){
			letra = fgetc(settingsCargados);// primer caracter sera punto debido a la definicion de saveGameHistory
			if(letra == EOF)break;
			else{
				// lectura de Movimientos de Jugadores y enemigos
					
			}
		}
	}
	fclose(settingsCargados);
}
/*!
*	\fn void saveGameHistory(char *fileName,GameHistory gameHistoryToWrite,int *statusCode)
	*  \brief Guarda los movimientos de todas las jugadas del ultimo juego.
	*  \param fileName nombre del archivo a leer.
	*  \param gameHistoryToWrite estructura ConfigParam, contiene las jugadas del ultimo juego.
	*	\param statusCode parametro que indica si el procedimiento tuvo un error en la escritura.
	*/
DLL_EXP void CALL saveGameHistory(char *fileName,GameHistory gameHistoryToWrite,int *statusCode){
	FILE *settingsAEscribir;
	fopen_s(&settingsAEscribir,fileName,"w");
	if (settingsAEscribir == NULL){*statusCode = ERR_FILE_NOT_PERMISSION;}
	else{
		*statusCode = OK;
		fprintf(settingsAEscribir,"%d %d %d\n",gameHistoryToWrite.cantidadDeJugadores,gameHistoryToWrite.cantidadDeEnemigos,gameHistoryToWrite.mapaID);
		fputc('.',settingsAEscribir);
			// Aca iran en orden Movimientos de Jugadores y enemigos MovJugador movimientoEnemingo (con esa estructura hacia abajo)
	}
	//free(gameHistoryToWrite.jugadores);
	//free(gameHistoryToWrite.enemigos);
	fclose(settingsAEscribir);
	encriptar(fileName,"bin/gameHistoryEncriptado.txt");
}
	

	
	
/*!
*	\fn void loadSavedGame(char *fileName,SaveGame **savedGamesReaded,int *length,int *statusCode)
	*  \brief Carga la ultima configuracion de un jugador.
	*  \param fileName nombre de archivo a leer.
	*  \param savedGamesReaded direccion de memoria de un arreglo de estructuras SaveGame, no posee memoria asignada.
	*	\param length largo de texto leido, es asignado en el procedimiento.
	*	\param statusCode parametro que indica si el procedimiento tuvo un error en la lectura.
	*/
DLL_EXP void CALL loadSavedGame(char *fileName,SaveGame **savedGamesReaded,int *length,int *statusCode){
	FILE *settingsCargados;//!< Indica el archivo de texto de los juegos guardados.
	int numeroAux,numero,cont;//!< Indica el contador utilizado en los ciclos.
	char letra,*string;//!< Indica el caracter para el conteo de lineas.
	SaveGame* saveGameAux;
		
	string = (char*)malloc(sizeof(char) * 10);
	*length = 0;
	letra = ' ';
	fopen_s(&settingsCargados,fileName,"r");
		
	if (settingsCargados == NULL){*statusCode =	ERR_FILE_NOT_FOUND;}
	else{
		*statusCode = OK;
		while(letra != EOF){
			letra = fgetc(settingsCargados);
			if(letra == '\n')
				(*length)++;
		}
	}
	fclose(settingsCargados);
		
	*savedGamesReaded = (SaveGame*)malloc(sizeof(SaveGame) * (*length));
		
	saveGameAux = *savedGamesReaded;
		
	for(numero = 0; numero < *length; numero++){
		saveGameAux[numero].jugador.alias = NULL;
		saveGameAux[numero].jugador.idAmigos = NULL;
		saveGameAux[numero].jugador.mejorPuntuacion = NULL;
		saveGameAux[numero].jugador.movimientos = NULL;
		saveGameAux[numero].jugador.trofeosRecolectados = NULL;
	}
		
	fopen_s(&settingsCargados,fileName,"r");
	if (settingsCargados == NULL){*statusCode = ERR_FILE_NOT_FOUND;}
	else{
		*statusCode = OK;
		for (cont = 0 ; cont < *length ; cont++){	
	 		saveGameAux[cont].jugador.alias = (char*)malloc(sizeof(char)*32);
			saveGameAux[cont].nombreArchivo = (char*)malloc(sizeof(char)*32);
			fscanf_s(settingsCargados,"%s\n",saveGameAux[cont].nombreArchivo);
	 		fscanf_s(settingsCargados,"%d %s %d %c",&(saveGameAux[cont].jugador.ID),saveGameAux[cont].jugador.alias,&(saveGameAux[cont].mapaID),&letra);
	 		while(letra != '\n'){
	 			if(letra == '<')
	 				fgets(string,5,settingsCargados);
	 			letra = fgetc(settingsCargados);
	 			if(letra != '>' && letra != '<' && letra != ' '){
		 			if(0 == strcmp(string,"move")){
				 		if(letra == '{'){
				 			fscanf_s(settingsCargados,"%d %c ",&numero,&letra);
				 			if(numero == 0){
				 				saveGameAux[cont].jugador.movimientos = NULL;
				 				letra = '\n';
				 			}else
				 				saveGameAux[cont].jugador.movimientos = (Movimiento*)malloc(sizeof(Movimiento) * numero);
				 			saveGameAux[cont].jugador.largoMovimientos = numero;
				 			numero = 0;
				 			numeroAux = 0;
				 		}
				 		else if(letra >= '0' && letra <= '9'){
				 			switch(numero){
				 				case 0:
				 					saveGameAux[cont].jugador.movimientos[numeroAux].tipoDeMovimiento = letra - '0';
				 					numero++;
				 					break;
				 				case 1:
				 					saveGameAux[cont].jugador.movimientos[numeroAux].direccionDelMovimiento.x = letra - '0';
				 					numero++;
				 					break;
				 				case 2:
				 					saveGameAux[cont].jugador.movimientos[numeroAux].direccionDelMovimiento.y = letra - '0';
				 					numero = 0;
				 					numeroAux++;
				 					break;
								}
						}
					}
		 			else if(0 == strcmp(string,"punt")){
				 		if(letra == '{'){
				 			fscanf_s(settingsCargados,"%d %c ",&numero,&letra);
				 			if(numero == 0){
				 				saveGameAux[cont].jugador.mejorPuntuacion = NULL;
				 				letra = '\n';
				 			}else
				 				saveGameAux[cont].jugador.mejorPuntuacion = (int*)malloc(sizeof(int) * numero);
				 			saveGameAux[cont].jugador.largoDePuntuaciones = numero;
				 			numero = 0;
				 		}else if(letra >= '0' && letra <= '9'){
					 		saveGameAux[cont].jugador.mejorPuntuacion[numero] = letra - '0';
					 		numero++;
					 	}
		 			}
		 			else if(0 == strcmp(string,"amgo")){
				 		if(letra == '{'){
				 			fscanf_s(settingsCargados,"%d %c ",&numero,&letra);
				 			if(numero == 0){
				 				saveGameAux[cont].jugador.idAmigos = NULL;
				 				letra = '\n';
				 			}else
				 				saveGameAux[cont].jugador.idAmigos = (int*)malloc(sizeof(int) * numero);
				 			saveGameAux[cont].jugador.largoDeAmigos = numero;
				 			numero = 0;
				 		}else if(letra >= '0' && letra <= '9'){
				 			saveGameAux[cont].jugador.idAmigos[numero] = letra - '0';
				 			numero++;
				 		}
		 			}
		 			else if(0 == strcmp(string,"trof")){
				 		if(letra == '{'){
				 			fscanf_s(settingsCargados,"%d %c ",&numero,&letra);
				 			if(numero == 0){
				 				saveGameAux[cont].jugador.trofeosRecolectados = NULL;
				 				letra = '\n';
				 			}else
				 				saveGameAux[cont].jugador.trofeosRecolectados = (Trofeo*)malloc(sizeof(Trofeo) * numero);
				 			saveGameAux[cont].jugador.largoTrofeosRecolectados = numero;
				 			numero = 0;
				 		}else if(letra >= '0' && letra <= '9'){
					 		saveGameAux[cont].jugador.trofeosRecolectados[numero].ID = letra - '0';
					 		numero++;
					 	}
		 			}
			}
		}
	}
	fclose(settingsCargados);
	}
}
/*!
*	\fn void saveGame(char *fileName,SaveGame *savedGamesToWrite,int length,int *statusCode)
	*  \brief Guarda la configuracion actual del jugador.
	*  \param fileName archivo donde se guardara la configuracion.
	*  \param savedGamesToWrite arreglo de estructuras SaveGame, contiene las configuraciones.
	*	\param length largo del arreglo savedGamesToWrite.
	*	\param statusCode parametro que indica si el procedimiento tuvo un error en la escritura.
	*/
	 
	
	 
DLL_EXP void CALL saveGame(char *fileName,SaveGame *savedGamesToWrite,int length,int *statusCode){
	FILE *settingsAEscribir; 
	int cont,contAux;
	fopen_s(&settingsAEscribir,fileName,"w");
	if (settingsAEscribir == NULL){*statusCode = ERR_FILE_NOT_PERMISSION;}
	else{
		*statusCode = 0;
		for(cont = 0;cont<length;cont++){
			fprintf(settingsAEscribir,"%s\n",savedGamesToWrite[cont].nombreArchivo);
			fprintf(settingsAEscribir,"%d %s %d",savedGamesToWrite[cont].jugador.ID,savedGamesToWrite[cont].jugador.alias,savedGamesToWrite[cont].mapaID);
			fprintf(settingsAEscribir," <move>{%d}",savedGamesToWrite[cont].jugador.largoMovimientos);
			for(contAux = 0; contAux < savedGamesToWrite[cont].jugador.largoMovimientos ; contAux++){
				fprintf(settingsAEscribir," %d%d%d",savedGamesToWrite[cont].jugador.movimientos[contAux].tipoDeMovimiento,savedGamesToWrite[cont].jugador.movimientos[contAux].direccionDelMovimiento.x,savedGamesToWrite[cont].jugador.movimientos[contAux].direccionDelMovimiento.y);
			}
			fprintf(settingsAEscribir," <trof>{%d}",savedGamesToWrite[cont].jugador.largoTrofeosRecolectados);
			for(contAux = 0; contAux < savedGamesToWrite[cont].jugador.largoTrofeosRecolectados ; contAux++){
				fprintf(settingsAEscribir," %d",savedGamesToWrite[cont].jugador.trofeosRecolectados[contAux].ID);
			}
			fprintf(settingsAEscribir," <punt>{%d}",savedGamesToWrite[cont].jugador.largoDePuntuaciones);
			for(contAux = 0; contAux < savedGamesToWrite[cont].jugador.largoDePuntuaciones ; contAux++){
				fprintf(settingsAEscribir," %d",savedGamesToWrite[cont].jugador.mejorPuntuacion[contAux]);
			}
			fprintf(settingsAEscribir," <amgo>{%d}",savedGamesToWrite[cont].jugador.largoDeAmigos);
			for(contAux = 0; contAux < savedGamesToWrite[cont].jugador.largoDeAmigos ; contAux++){
				fprintf(settingsAEscribir," %d",savedGamesToWrite[cont].jugador.idAmigos[contAux]);
			}
			fputc('\n',settingsAEscribir);
		}
	}
	//free(savedGamesToWrite);
	fclose(settingsAEscribir);
	encriptar(fileName,"bin/saveEncriptado.txt");
}
