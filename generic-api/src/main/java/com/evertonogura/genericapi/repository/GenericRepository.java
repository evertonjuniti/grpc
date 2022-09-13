package com.evertonogura.genericapi.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.evertonogura.genericapi.entity.GenericEntity;

public interface GenericRepository extends JpaRepository<GenericEntity, Long> {

}
