/// <vs BeforeBuild='default' />
/// <reference path="E:\VCS\Systtech\Support\IKovalenko\SupportProject\Support.CallCenter.Ui\Scripts/jquery-2.1.3.min.js" />
// Обязательная обёртка
module.exports = function (grunt) {

    //загружаем все грунт модули из package.json
    require('load-grunt-tasks')(grunt);

    // Задачи
    grunt.initConfig({
        // Склеиваем
        concat: {
            options: {
                separator: ";\n"
            },
            controllers: {
                src: ["Frontend/Controllers/*.js"],
                dest: "FrontendBuild/controllers.js"
            },
            directives: {
                src: ["Frontend/Directives/**/*.js"],
                dest: "FrontendBuild/direcives.js"
            },
            services: {
                src: ["Frontend/Services/*.js"],
                dest: "FrontendBuild/services.js"
            },
            modules: {
                src: ["Frontend/Modules/*.js"],
                dest: "FrontendBuild/modules.js"
            },
            application: {
                src: ["Frontend/application.js"],
                dest: "FrontendBuild/application.js"
            }
        },
        concat_css: {
            styles: {
                src: ["Frontend/Styles/*.css"],
                dest: "FrontendBuild/styles.css"
            }
        }
        //,
        // Сжимаем
        //uglify: {
        //    frontend: {
        //        files: {
        //            // Результат задачи concat
        //            "FrontendBuild/frontend.min.js": "<%= concat.frontend.dest %>"
        //        }
        //    }
        //}
    });
    
    // Задача по умолчанию
    grunt.registerTask("default", ["concat", "concat_css"]);
};