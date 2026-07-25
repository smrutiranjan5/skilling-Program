# React Exercise 4 - React Component Lifecycle

## Objective
- Understand React Component Lifecycle.
- Implement `componentDidMount()` lifecycle method.
- Implement `componentDidCatch()` lifecycle method.
- Fetch data from REST API using Fetch API.
- Display fetched blog posts using a Class Component.

## Technologies Used
- React JS
- JavaScript (ES6)
- HTML
- CSS
- Fetch API

## Project Structure

```
4.ReactJS-HOL
│
├── blogapp
│   ├── src
│   │   ├── App.js
│   │   ├── Post.js
│   │   ├── Posts.js
│   │   ├── index.js
│   │   ├── App.css
│   │   └── index.css
│   │
│   ├── public
│   ├── package.json
│   └── ...
│
├── Screenshots
│   ├── FolderStructure.png
│   ├── VSCode.png
│   └── Output.png
│
└── README.md
```

## Features
- Class Component
- React Lifecycle Methods
- componentDidMount()
- componentDidCatch()
- Fetch API
- REST API Integration
- Dynamic Rendering using State

## API Used

```
https://jsonplaceholder.typicode.com/posts
```

## Lifecycle Methods Used

### componentDidMount()

- Executes after the component is rendered.
- Fetches blog posts from the API.
- Updates the component state.

### componentDidCatch()

- Handles runtime errors in the component.
- Displays an alert if any error occurs.

## Output

The application displays:

- Blog Posts heading
- Title of each post
- Body of each post
- Posts fetched dynamically from the API

## Screenshots

Store the following screenshots inside the **Screenshots** folder:

- Folder Structure
- VS Code Project
- Browser Output

