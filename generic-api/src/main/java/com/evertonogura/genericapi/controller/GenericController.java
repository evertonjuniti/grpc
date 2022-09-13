package com.evertonogura.genericapi.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.evertonogura.genericapi.model.GenericModel;
import com.evertonogura.genericapi.service.GenericService;

@RestController
@RequestMapping("/api")
@CrossOrigin(origins="*")
public class GenericController {
	
	@Autowired
	private GenericService genericService;
	
	@PostMapping("/generics")
	public ResponseEntity<GenericModel> newGeneric(@RequestBody GenericModel newGeneric) {
		return ResponseEntity.status(HttpStatus.CREATED).body(genericService.newGeneric(newGeneric));
	}
	
	@PutMapping("/generics/{id}")
	public ResponseEntity<GenericModel> updateGeneric(@PathVariable Long id, @RequestBody GenericModel newGeneric) {
		return ResponseEntity.status(HttpStatus.OK).body(genericService.updateGeneric(id, newGeneric));
	}
	
	@GetMapping("/generics")
	public ResponseEntity<List<GenericModel>> all() {
		return ResponseEntity.status(HttpStatus.OK).body(genericService.listGeneric());
	}
	
	@GetMapping("/generics/{id}")
	public ResponseEntity<GenericModel> one(@PathVariable Long id) {
		return ResponseEntity.status(HttpStatus.OK).body(genericService.getGeneric(id));
	}
	
	@DeleteMapping("/generics/{id}")
	public ResponseEntity<Void> deleteArtista(@PathVariable Long id) {
		genericService.deleteGeneric(id);
		return ResponseEntity.status(HttpStatus.NO_CONTENT).body(null);
	}
	
}
