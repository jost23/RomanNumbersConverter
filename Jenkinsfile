pipeline {
  agent any
  stages {
    stage('Step 1') {
      steps {
	    echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL} in branch ${env.GIT_BRANCH}"
      }
    }
	stage('Git 2') {
      steps {
        echo "Step 2"
      }
    }
  }
}