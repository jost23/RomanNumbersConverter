pipeline {
  agent any
    
  triggers {
    pollSCM('') // Enabling being build on Push
  }
  
  stages {
    def msbuild =  "%windir%/Microsoft.NET/Framework/v4.0.30319/MsBuild.exe"
	def novaMsBuild = "RomanNumbersConverter.msbuild"
	def nologo = "/nologo"
    stage('Build App with MsBuild') {
    	echo "Build App with MsBuild"
    	def exitStatus = bat(returnStatus: true, script: "${msbuild} ${novaMsBuild} ${nologo} /target:BuildApp")
        if (exitStatus != 0){
            currentBuild.result = 'FAILURE'
            error 'Frontends - failed'
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