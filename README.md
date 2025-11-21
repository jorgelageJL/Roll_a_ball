# My Ball Project

Un pequeño juego creado en **Unity** donde controlas una bola que se mueve por el escenario, recoge objetos ("pickups"), evita caer fuera del mapa y escapa de un enemigo controlado por **IA con NavMeshAgent**.  
El juego incluye un menú inicial, cambio de escenas, botón de reinicio y un sistema de victoria basado en recoger todos los objetos.

---

## Características

- Movimiento fluido del jugador usando el **Nuevo Input System**
- Salto con la tecla **Espacio**
- Recolección de pickups que desaparecen al tocarlos
- Contador de objetos recogidos (UI con TextMeshPro)
- Mensaje de victoria
- Enemigo con IA que persigue al jugador usando **NavMesh + NavMeshAgent**
- Colisión con el enemigo produce un reinicio de la partida
- Diseño simple y educativo basado en el clásico Roll-a-Ball

---

## 🧩 Escenas del proyecto

| Escena          | Descripción |
|-----------------|-------------|
| **Menu.unity**  | Pantalla inicial con botón para comenzar el juego |
| **Minigame.unity** | Nivel principal donde se juega la partida |

---

## Requisitos del sistema

- Unity versión **6000.1** o superior  
- Nuevo Input System activado  
- Paquete `TextMeshPro` instalado

---

## Estructura del proyecto

Assets/
├── Materials/ # Materiales del jugador, enemigo, suelo...
├── Prefabs/ # Prefabs de pickups u objetos
├── Scenes/
│ ├── Menu.unity # Menú inicial
│ └── Minigame.unity # Escena principal del juego
├── Scripts/
│ ├── CameraController.cs # Movimiento de cámara
│ ├── EnemyMovement.cs # IA del enemigo (NavMesh + NavMeshAgent)
│ ├── PlayerController.cs # Control del jugador, salto y recogidas
│ ├── Rotator.cs # Rotación de los pickups
│ └── UIManager.cs # Gestión de botones y reinicios
└── UI/
└── TextMesh Pro/ # Contadores y mensajes



---

## Scripts principales

### `PlayerController.cs`
Controla el movimiento, salto, recogida de objetos y reinicio de la escena.

### `CameraController.cs`
Hace que la cámara siga suavemente a la bola.

### `Rotator.cs`
Hace girar los pickups para darles dinamismo visual.

### `EnemyMovement.cs`
Controla la inteligencia artificial del enemigo mediante NavMeshAgent.  
Persigue al jugador y reinicia la partida al colisionar con él.

### `UIManager.cs`
Controla la UI del juego:
- Botón para reiniciar la partida
- Activación de elementos UI según el estado del juego

---

## Cómo ejecutar el proyecto

1. Abre Unity Hub.
2. Crea un proyecto nuevo con la plantilla 3D (Core).
3. Copia la carpeta del proyecto o clónala desde GitHub.
4. Abre la escena principal (`MiniGame.unity`).
5. Presiona *Play* para jugar.

---

## Créditos

- Desarrollado por: **Jorge Lage**
- Hecho con: [Unity](https://unity.com/)
- Basado en tutoriales de Unity Learn y prácticas del curso de GSDAM, también buscando por errores en ChatGPT.

---

## Licencia

Este proyecto es de uso educativo. Puedes modificarlo y distribuirlo libremente citando al autor original.
