# 💳 Fulbank

## 🧾 Description
Fulbank est un environnement de développement intégré destiné à la gestion des distributeurs automatiques de billets (DAB) pour une banque moderne.
Il permet le contrôle et la supervision de distributeurs prenant en charge à la fois la monnaie fiduciaire (euros, dollars) et la cryptomonnaie (Bitcoin, Ethereum).

## ⚙️ Installation
L’installation est simple et rapide grâce au fichier MSI fourni.

## 🔗 Télécharger
Cliquez ici pour télécharger le programme (.msi)

Une fois le fichier téléchargé :

Double-cliquez sur le fichier .msi.

Suivez les instructions de l’installateur.

Lancez l’application depuis le menu démarrer ou le raccourci sur le bureau.

## 📤 Dump de la base de données
Un fichier de dump SQL est disponible pour initialiser la base avec les structures et données de base nécessaires.

Télécharger le dump SQL
(À remplacer par un lien vers le fichier .sql sur le dépôt ou un hébergement externe)

## 📌 Instructions pour l'import :
Créez une base vide (ex. atm_ide_db) dans votre SGBD (MySQL).

```
mysql -u root -p atm_ide_db < chemin/vers/le_fichier_dump.sql
```

Lancez l’application et connectez-vous à cette base via le fichier Params/config.ini au sein de la solution.
