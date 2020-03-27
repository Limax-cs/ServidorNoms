#include <stdio.h>
#include <string.h>
#include <mysql.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <unistd.h>
#include <sys/types.h>
#include <ctype.h>

int main(int argc, char *argv[]) {
	
	//Variables
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticio [512];
	char resposta [512];
	
	//obrir el socket
	if((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant el socket");
	
	//Incialoitzem a zero el serv_adr
	memset(&serv_adr,0,sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	//Associem el socket a una màquina
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	
	//Definim el port
	serv_adr.sin_port = htons(9070);
	
	//Fem el bind i l'escolta
	if (bind(sock_listen, (struct sockaddr * ) & serv_adr,sizeof(serv_adr)) < 0)
		printf("Error al bind");
	if (listen(sock_listen, 3) < 0)
		printf("Error en el listen");
	
	
	//Comencem amb el bucle
	
	for (;;) {
		
		printf("Escoltant\n");
		
		//Detecta la connexió
		sock_conn = accept (sock_listen, NULL, NULL);
		printf("Ha rebut la connexio\n");
		
		//Bucle d'atenció al client
		int acabar = 0;
		while (acabar == 0)
		{
			//Rep el senyal
			ret = read (sock_conn, peticio, sizeof(peticio));
			printf("Rebut\n");
			peticio[ret] = '\0';
			printf("Petició: %s \n", peticio);
			
			//Procesa el missatge
			char *p = strtok(peticio,"/");
			int codi = atoi (p);
			
			if (codi == 0)
				acabar = 1;
			else
				{
				p = strtok(NULL,"/");
				char nom [20];
				strcpy(nom,p);
				

				if (codi == 1)
				{
					sprintf(resposta, "%d,", strlen(nom));
				}
				else if (codi == 2)
				{
					if((nom[0] == 'M') || (nom[0] == 'J'))
						strcpy(resposta,"SI");
					else
						strcpy(resposta,"NO");
				}
				else if (codi == 3)
				{
					p = strtok(NULL,"/");
					float altura = atof (p);
					if (altura > 1.70)
						sprintf(resposta,"%s: ets alt", nom);
					else
						sprintf(resposta,"%s: ets baix", nom);
				}
				else if (codi == 4)
				{
					int Palindrom = 1;
					int i = 0;
					while ((i <strlen(nom)/2)&&(Palindrom != 0))
					{
						if(nom[i] != nom[strlen(nom) -1 -i])
						{
							if(toupper(nom[i]) != toupper(nom[strlen(nom) -1 -i]))
								Palindrom = 0;
							else
								Palindrom = 2;
						}
						
						i++;
					}
					if (Palindrom == 0)
						sprintf(resposta, "NO");
					else if (Palindrom == 1)
						sprintf(resposta, "SI");
					else
						sprintf(resposta, "Sí-NoMajusc");
				}
				else
				{
					char nomMajus [20];
					for(int i = 0; i < strlen(nom); i++)
						nomMajus[i] = toupper(nom[i]);
					nomMajus[strlen(nom)] = '\0';
					sprintf(resposta,"%s",(nomMajus));
				}
				
				printf("Resposta: %s \n",resposta);
				//Envia la resposta i tanca la connexió
				write (sock_conn, resposta, strlen(resposta));
			}
		}
		
		close (sock_conn);
	}
}

