# Gestionnaire vCard

Un gestionnaire de contacts simple et efficace en **C#** qui permet de créer, gérer et exporter des contacts au format vCard (`.vcf`).

## Fonctionnalités

- Ajouter de nouveaux contacts
- Afficher tous les contacts
- Rechercher un contact par nom ou prénom
- Supprimer un contact
- Exporter les contacts au format vCard (`.vcf`)
- Validation des données d'entrée
- Gestion automatique des dossiers de destination

## Structure du projet

Le projet est composé de trois classes principales :

### Classe `Contact`

Représente un contact individuel avec les propriétés suivantes :

- **Name** : Nom de famille
- **FirstName** : Prénom
- **Phone** : Numéro de téléphone
- **Mail** : Adresse email

### Classe `VCard`

Contient toute la logique métier pour gérer les contacts.

#### Méthodes principales :

- `AddContact()` : Ajoute un nouveau contact à la liste
- `DisplayContacts()` : Affiche tous les contacts
- `SearchContactByName()` : Recherche un contact par nom/prénom
- `RemoveContactByName()` : Supprime un contact
- `ConvertToVCF()` : Convertit un contact au format vCard
- `ExportToVCFIndividuals()` : Exporte tous les contacts en fichiers séparés

#### Méthodes utilitaires :

- `CreateFileIfNecessary()` : Crée le dossier de destination si nécessaire
- `GenerateSecureFileName()` : Génère un nom de fichier sécurisé
- `ManageDuplicatesFileName()` : Gère les doublons de noms de fichiers
- `ValidateRoadFile()` : Valide le chemin de fichier

### Classe `Program`

Contient l'interface utilisateur en ligne de commande avec un menu interactif.

---

## Utilisation

### Lancement du programme

Compilez et exécutez le programme. Un menu interactif s'affichera :

```
+----------------------------------------+
| Bienvenue dans le gestionnaire vCard   |
+----------------------------------------+
```

Vous pouvez choisir une option :

1. Afficher tous les contacts
2. Ajouter un nouveau contact
3. Rechercher un contact par nom
4. Supprimer un contact par nom
5. Exporter tous les contacts dans des fichiers (.vcf) séparés
6. Sortir

### Options disponibles

#### 1. Afficher tous les contacts

Liste tous les contacts enregistrés avec leurs informations complètes.

#### 2. Ajouter un nouveau contact

Demande de saisir :

- Nom (obligatoire)
- Prénom (obligatoire)
- Numéro de téléphone (obligatoire)
- Adresse email (obligatoire)

#### 3. Rechercher un contact

Permet de rechercher un contact en tapant une partie de son nom ou prénom. La recherche est insensible à la casse.

#### 4. Supprimer un contact

Supprime un contact de la liste en recherchant par nom.

#### 5. Exporter les contacts

Crée un fichier `.vcf` individuel pour chaque contact dans le dossier :

```
Bureau/Contacts_VCF/
```

#### 6. Sortir

Ferme l'application.

---

## Format des fichiers exportés

Les contacts sont exportés au format **vCard 3.0** standard :

```
BEGIN:VCARD
VERSION:3.0
FN:Jean Dupont
N:Dupont;Jean;;;
TEL:0123456789
EMAIL:jean.dupont@email.com
END:VCARD
```

---

## Gestion des erreurs

Le programme inclut une gestion robuste des erreurs :

- Validation des champs obligatoires
- Création automatique des dossiers manquants
- Gestion des caractères interdits dans les noms de fichiers
- Gestion des doublons de noms de fichiers
- Messages d'erreur informatifs

---

## Structure des fichiers

```
vCard_Manager/
├── Contact.cs          # Classe Contact
├── VCard.cs           # Classe VCard (logique métier)
├── Program.cs         # Point d'entrée et interface utilisateur
└── README.md          # Ce fichier
```

---

## Prérequis techniques

- .NET Framework 4.7.2 ou supérieur
- Visual Studio 2019 ou supérieur (recommandé)
- Système d'exploitation Windows

---

## Installation et compilation

1. Clonez ou téléchargez le projet
2. Ouvrez le projet dans Visual Studio
3. Compilez le projet (`Ctrl+Shift+B`)
4. Exécutez le programme (`F5`)

---

## Exemple d'utilisation

```csharp
// Création d'une instance du gestionnaire
VCard manager = new VCard();
List<Contact> contacts = new List<Contact>();

// Ajout d'un contact
Contact contact = manager.AddContact(contacts, "Dupont", "Jean", 
                                   "0123456789", "jean@email.com");

// Exportation au format vCard
string vcfContent = manager.ConvertToVCF(contact);

// Exportation vers fichiers
manager.ExportToVCFIndividuals(contacts);
```