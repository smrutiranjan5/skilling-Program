import "./App.css";

import BookDetails from "./Components/BookDetails";
import BlogDetails from "./Components/BlogDetails";
import CourseDetails from "./Components/CourseDetails";

function App() {

    const books = [

        { id: 101, bname: "Master React", price: 670 },

        { id: 102, bname: "Deep Dive into Angular 11", price: 800 },

        { id: 103, bname: "Mongo Essentials", price: 450 }

    ];

    const blogs = [

        {
            id: 1,
            title: "React Learning",
            author: "Stephen Biz",
            description: "Welcome to learning React!"
        },

        {
            id: 2,
            title: "Installation",
            author: "Schwzdenier",
            description: "You can install React from npm."
        }

    ];

    const courses = [

        {
            id: 1,
            cname: "Angular",
            date: "4/5/2021"
        },

        {
            id: 2,
            cname: "React",
            date: "6/3/2020"
        }

    ];

    return (

        <div className="container">

            <CourseDetails courses={courses} />

            <BookDetails books={books} />

            <BlogDetails blogs={blogs} />

        </div>

    );

}

export default App;