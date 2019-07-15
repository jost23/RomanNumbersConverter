pipeline {
  agent any
  
  triggers {
    pollSCM('') // Enabling being build on Push
  }
  
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
	
	stage('Step 3') {
		when {
			// check if branch is master
            branch 'master'
        }
		steps {
			echo "This is master"
		}
	}
	
  }
  post {
        always {
            echo 'This will always run'
        }
        success {
            echo 'This will run only if successful'
        }
        failure {
            echo 'This will run only if failed'
        }
        unstable {
            echo 'This will run only if the run was marked as unstable'
        }
        changed {
            echo 'This will run only if the state of the Pipeline has changed'
            echo 'For example, if the Pipeline was previously failing but is now successful'
        }
    }
}