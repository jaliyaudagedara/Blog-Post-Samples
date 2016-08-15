var gulp = require('gulp');
var del = require('del');

var paths = {
    nodeModules: 'node_modules/**/*.js'
};

gulp.task('clean', function () {
    return del(['wwwroot/scripts/**/*']);
});

gulp.task('build', function () {
    gulp.src(paths.nodeModules).pipe(gulp.dest('wwwroot/scripts'))
});