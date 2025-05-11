## Contexte de la mission
InfoTech Services 86 (ITS86) est une ESN spécialisée dans le développement informatique (applications de bureau, web, mobile), l’hébergement de site web, l’infogérance, la gestion de parc informatique et l’ingénierie système et réseau. Elle répond régulièrement à des appels d’offres en tant que société d’infogérance et prestataire de services informatiques.

Parmi les marchés gagnés récemment par ITS86, on trouve celui de la gestion du parc informatique du réseau des médiathèques de la Vienne, MediaTek86, ainsi que l'informatisation de plusieurs activités internes des médiathèques ou en lien avec le public.

En tant que technicien développeur junior travaillant dans le pôle Développement d'ITS86, il m'a été confié le développement d'une application de bureau permettant de gérer les personnels de chaque médiathèque.

En plus du développement de l'application, il a été demandé de fournir une documentation technique au format html afin de faciliter sa maintenance ainsi qu'une vidéo de présentation des principales fonctionnalités de cette application à destination des utilisateurs.

## Description de l'application
Application de bureau windows permettant de gérer les personnels d'une médiathèque, leur affectation à un service et leurs absences. 

Il s'agit d'une application en POO et MVC destinée à être installée sur un poste d'un service administratif.

## Fonctionnalités

* une connexion sécurisée à la base de données MySQL comportant les données sur les personnels ;
* l'affichage de la liste des personnels avec la possibilité d'ajouter, modifier, supprimer un personnel ;
* l'affichage de la liste des absences d'un personnel sélectionné avec la possibilité d'ajouter, modifier ou supprimer une absence ;
* le contrôle des saisies de l'utilisateur afin de l'avertir en cas d'oubli de remplissage d'un champ d'information, de l'ajout d'une absence sur la même période qu'une autre déjà renseignée, ou d'incohérences concernant les dates de début et de fin de l'absence en cours de saisie.

## Installation

Les fichiers nécessaires à l'installation et le test de l'application sont disponibles dans le dossier [Installation](https://github.com/filkat34/MediaTek86/tree/d0b8eb1b6a32e3bd3c997cd51c0cc8a8ae4f0259/Installation) dans lequel sont contenus :

* un fichier d'installation au format MSI ;
* un script SQL de création de la base de données, des utilisateurs et d'insertion de données test.

Pour vous connecter et tester l'application, vous devez utiliser les identifiants suivants :
* login : **respo1**
* mot de passe : **respoMEDIA86@**

## Documentation

Vous pouvez télécharger la documentation technique sous format zip [ici](https://github.com/filkat34/MediaTek86/blob/59e4719eb9a322fd6d08852ef28db17ddaaeba77/DocuTechnique.zip).

Vous trouvrez une démonstration des différentes fonctionnalités de cette application en format vidéo en cliquant [ici]().


