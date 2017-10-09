Set the subscription
`az account set --subscription "ddfa2498-b009-4639-a7cb-2322cdf51d03"`

##Get credential for your cluster
`az acs kubernetes get-credentials --resource-group="Team-18" --name="Team18MCk8s" --ssh-key-file C:\Projects\team18-openhack\t18`

##Verify that you have connection with your cluster
`kubectl get pods --all-namespaces`

