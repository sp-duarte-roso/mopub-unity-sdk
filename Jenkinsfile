#!/usr/bin/env groovy
pipeline {
    parameters {
        string(name: 'UNITY_ROOT', defaultValue: '/Applications/Unity/Hub/Editor', description: 'Override the root directory of the agent Unity root')
        string(name: 'UNITY_VERSION', defaultValue: '2019.4.21f1', description: 'The version directory name of the Unity install')
        string(name: 'XCODE_VERSION', defaultValue: "${env.DEFAULT_XCODE}", description: 'Xcode version')
    }
    environment {
        JAVA_HOME = "/Library/Java/JavaVirtualMachines/jdk1.8.0_131.jdk/Contents/Home"
        UNITY_ROOT = "${params.UNITY_ROOT}"
        UNITY_VERSION = "${params.UNITY_VERSION}"
        UNITY_BIN = "${env.UNITY_ROOT}/${env.UNITY_VERSION}/Unity.app/Contents/MacOS/Unity"
        PARSED_JOB_NAME = URLDecoder.decode(env.JOB_NAME, "UTF-8")
        SLACK_JOB_NAME = "<${env.BUILD_URL}|${PARSED_JOB_NAME} #${env.BUILD_NUMBER}>"
        XCODE_VERSION = "${params.XCODE_VERSION}"
    }
    agent {
        node {
            label "${params.XCODE_VERSION}&&unity"
        }
    }
    stages {
        stage('Prepare') {
            steps {
                sh 'sudo xcode-select --switch ${!XCODE_VERSION}' // Select Xcode version
            }
        }
        stage('Build SDKs and Unity Package') {
            steps {
                wrap([$class: 'AnsiColorBuildWrapper', 'colorMapName': 'xterm']) {
                    echo "UNITY_ROOT: ${env.UNITY_ROOT}"
                    echo "UNITY_VERSION: ${env.UNITY_VERSION}"
                    echo "UNITY_PATH: ${env.UNITY_BIN}"
                    sh './scripts/build.sh'
                    archiveArtifacts 'mopub-unity-plugin/*.unitypackage'
                }
            }
        }
        stage('Run Unit Tests') {
            steps {
                wrap([$class: 'AnsiColorBuildWrapper', 'colorMapName': 'xterm']) {
                    sh './scripts/run_unit_tests.sh'
                }
            }
        }
        stage('Build Sample Apps') {
            steps {
                wrap([$class: 'AnsiColorBuildWrapper', 'colorMapName': 'xterm']) {
                    sh './scripts/private/build-sample-apps.sh'
                    archiveArtifacts 'unity-sample-app/Build/*.apk'
                    archiveArtifacts 'unity-sample-app/Build/*.ipa.zip'

                    echo "Finished job with the following environment:"
                    echo "UNITY_ROOT: ${env.UNITY_ROOT}"
                    echo "UNITY_VERSION: ${env.UNITY_VERSION}"
                    echo "UNITY_PATH: ${env.UNITY_BIN}"
                }
            }
        }
    }
    post {
        success {
            wrap([$class: 'BuildUser']) {
                script {
                    def firstBuild = !currentBuild.previousBuild;
                    def lastBuildResult = !firstBuild && currentBuild.previousBuild.result
                    echo "BUILD SUCCESS!! :aww-yeah:"
                    if (firstBuild || lastBuildResult != currentBuild.result) {
                        slackSend color: 'GREEN', message: "${SLACK_JOB_NAME} has succeeded."
                    }
                    def user = env.BUILD_USER_ID
                    if( user ) {
                        slackSend channel: "@${user}", color: 'GREEN', message: "The build you triggered ${SLACK_JOB_NAME} has succeeded."
                    }
                }
            }
        }
        failure {
            slackSend color: 'RED', message: "Attention @here ${SLACK_JOB_NAME} has failed."
        }
        always {
            archiveArtifacts 'scripts/*log.txt'
        }
    }
}
