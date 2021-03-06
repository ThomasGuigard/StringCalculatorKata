Evaluation finale du cours .NET � l'IUT Lyon 1
==============================================

Crit�res d'�valuation
---------------------

* Solution apport�e aux probl�mes pos�s dans le fichier Readme.md + r�ponses aux questions (� mettre dans le fichier ci-dessous)
* La qualit� des commits : granularit� fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont �t� modifi�s, c'est inutile, Git le dit d�j�)
* La qualit� du code : utiliser un nommage correct + R# donne des r�gles � respecter, il suffit de les corriger
* Les tests unitaires : expressivit� (le nommage tout particuli�rement), granularit� (i.e on teste une chose � la fois), rapidit� (i.e instantan�), couverture de code et ind�pendance (un test ne d�pend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour �viter de faire du code difficilement maintenable et �volutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et m�thodes donn�s (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez � pousser vos commits sur votre compte GitHub et envoyer votre d�p�t � mon adresse mail.

R�ponses aux questions pos�es
-----------------------------

Q1) On peut utiliser des classes pour chaque op�rateur

Q2) POO permet de refactoriser le code afin de d�grouper et cacher certaines parties de code � l'utilisateur, pour y acc�der on passe par les objets et des accesseurs. On ne dispose pas d'acc�s direct.

Q3) Le but est d'abstraire le code afin de le rendre moins complexe et plus compr�hensible

Q4) - Les op�rations devraient �tres rentr�es directement dans la console
	- Gestion des erreurs � faire
	- L'application se ferme automatiquement � la fin

Q5) La refactorisation, all�ger les classes principales au niveau des d�pendances, allegement de la couche m�tier

Q6) On s�pare avec des interfaces afin de diminuer le couplage entre les classes 
 