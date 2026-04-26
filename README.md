# TypingRush

[![Tech Stack](https://img.shields.io/badge/Stack-JS_Vanilla_|_ASP.NET_8-blue)](https://github.com/karldiril/typingrush)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

**TypingRush** est une application web de dactylographie minimaliste centrée sur la performance et l'expérience utilisateur. Directement inspiré de Monkeytype, le projet permet de mesurer sa vitesse de frappe (WPM) et sa précision en temps réel dans un environnement épuré.

---

## 🛠 Tech Stack

| Composant | Technologie |
| :--- | :--- |
| **Frontend** | Vanilla JavaScript (ES6+), HTML5, CSS3 |
| **Backend** | ASP.NET Core 8 Web API |
| **Database** | PostgreSQL + Entity Framework Core |
| **Architecture** | REST API |

---

## 🏗 Architecture du projet

Le dépôt est organisé pour séparer la logique client de la persistence des données.

```text
typingrush/
├── frontend/           # Application Client (Static)
│   ├── assets/         # Images, fonts et fichiers statiques
│   ├── css/            # Styles modulaires (Layout, Themes)
│   ├── js/             # Logique applicative (Engine, UI, Stats)
│   └── index.html      # Point d'entrée principal
├── backend/            # API de persistence (.NET)
│   └── TypingRush.API/ # Endpoints et Logique métier
└── docs/               # Documentation technique et spécifications
